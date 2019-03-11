using AvioPrevoznik.DomainModel;
using Neo4j.Driver.V1;
using Neo4jClient;
using Neo4jClient.Cypher;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AvioPrevoznik
{
    public class DataManager
    {
        public static GraphClient client;

        #region Metode za avione

        public static void DodajAvion(Avion a)
        {
            int noviId = Int32.Parse(getMaxId()) + 1;

            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            queryDict.Add("id", noviId.ToString());
            queryDict.Add("marka", a.marka);
            queryDict.Add("brojsedista", a.brojsedista.ToString());
            queryDict.Add("godinaproizvodnje", a.godinaproizvodnje);

            var query = new Neo4jClient.Cypher.CypherQuery("CREATE (n:Avion {id:'" + noviId + "', marka:'" + a.marka + "', brojsedista:'" + a.brojsedista + "', godinaproizvodnje:'" + a.godinaproizvodnje
                                                            + "'}) return n",
                                                            queryDict, CypherResultMode.Set);

            ((IRawGraphClient)client).ExecuteGetCypherResults<Avion>(query);

            //MATCH (l: Let),(a: Avion)
            //WHERE l.id = '111' AND a.id = '1114'
            //CREATE (l)-[pr: LETI_NA]->(a)
            //RETURN l, a
            var query2 = new Neo4jClient.Cypher.CypherQuery("MATCH (a2: Aerodrom),(a1: Avion)" +
                                                            "WHERE a1.id = '" + noviId + "' AND a2.id = '" + a.aerodrom.id + "'" +
                                                            "CREATE (a1)-[pr: GARAZIRAN_NA]->(a2)" +
                                                            "RETURN a2",
                                                                        queryDict, CypherResultMode.Set);

            ((IRawGraphClient)client).ExecuteGetCypherResults<Aerodrom>(query2);
        }

       

        public static Avion GetAvion(int id)
        {
            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            queryDict.Add("id", id.ToString());

            var query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) where (n:Avion) and exists(n.id) and n.id = {id} return n",
                                                            queryDict, CypherResultMode.Set);

            List<Avion> avioni = ((IRawGraphClient)client).ExecuteGetCypherResults<Avion>(query).ToList();

            //MATCH(l) -[pr: LETI_NA]->(a)
            //WHERE a.id = '1114'
            //RETURN l
            var query2 = new Neo4jClient.Cypher.CypherQuery("MATCH (a1)-[pr: GARAZIRAN_NA]->(a2)" +
                                                            "WHERE a1.id = '" + id + "'" +
                                                            "RETURN a2",
                                                                        queryDict, CypherResultMode.Set);

            List<Aerodrom> aerodromi = ((IRawGraphClient)client).ExecuteGetCypherResults<Aerodrom>(query2).ToList();

            foreach (Avion a in avioni)
            {
                if (aerodromi.Count == 1)
                    foreach (Aerodrom aer in aerodromi)
                    {
                        a.aerodrom = aer;
                        return a;
                    }
                return a;
            }

            return null;
        }
        public static List<Avion> VratiSveAvione()
        {
            Dictionary<string, object> d = new Dictionary<string, object>();

            //var query = client.Cypher.Match("(user:Avion)").Return(user => user.As<Avion>()).Results;

            var query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) where (n:Avion) return n",
                                                           d, CypherResultMode.Set);

            List<Avion> avioni = ((IRawGraphClient)client).ExecuteGetCypherResults<Avion>(query).ToList();

            return avioni;
        }

       
        public static void AzurirajAvion(Avion a)
        {
            var query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) where (n:Avion) and exists(n.id) and n.id = '" + a.id + "'" +
                                                                " set n.marka = '" + a.marka + "'," +
                                                                " n.brojsedista = '" + a.brojsedista + "'," +
                                                                " n.godinaproizvodnje = '" + a.godinaproizvodnje + "'" +
                                                                " return n",
                                                            new Dictionary<string, object>(), CypherResultMode.Set);


            List<Avion> avioni = ((IRawGraphClient)client).ExecuteGetCypherResults<Avion>(query).ToList();

            //MATCH(n { id: '1116' })-[r: GARAZIRAN_NA]->(m { id: '1117' })
            //DELETE r
            var query2 = new Neo4jClient.Cypher.CypherQuery("MATCH(n { id: '" + a.id + "' })-[r: GARAZIRAN_NA]->() " +
                                                            "DELETE r " +
                                                            "RETURN n",
                                                             new Dictionary<string, object>(), CypherResultMode.Set);

            ((IRawGraphClient)client).ExecuteGetCypherResults<Avion>(query2);

            //MATCH (l: Let),(a: Avion)
            //WHERE l.id = '111' AND a.id = '1114'
            //CREATE (l)-[pr: LETI_NA]->(a)
            //RETURN l, a
            var query3 = new Neo4jClient.Cypher.CypherQuery("MATCH (a2: Aerodrom),(a1: Avion)" +
                                                            "WHERE a1.id = '" + a.id + "' AND a2.id = '" + a.aerodrom.id + "'" +
                                                            "CREATE (a1)-[pr: GARAZIRAN_NA]->(a2)" +
                                                            "RETURN a2",
                                                             new Dictionary<string, object>(), CypherResultMode.Set);

            ((IRawGraphClient)client).ExecuteGetCypherResults<Aerodrom>(query3);

        }
        public static void IzbrisiAvion(int id)
        {
            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            queryDict.Add("id", id.ToString());

            var query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) where (n:Avion) and exists(n.id) and n.id = {id} detach delete n",
                                                            queryDict, CypherResultMode.Projection);

            List<Avion> avioni = ((IRawGraphClient)client).ExecuteGetCypherResults<Avion>(query).ToList();
        }

        #endregion

        #region Metode za letove

        public static void DodajLet(Let l)
        {
           
            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            queryDict.Add("id", l.id);
            queryDict.Add("datumpolaska", l.datumpolaska);
            queryDict.Add("vremepolaska", l.vremepolaska);
            queryDict.Add("vremeletenja", l.vremeletenja);
            queryDict.Add("osnovnacena", l.osnovnacena);
            queryDict.Add("brojsedista", l.brojsedista);

            var query = new Neo4jClient.Cypher.CypherQuery("CREATE (n:Let {id:'" + l.id + "', datumpolaska:'" + l.datumpolaska
                                                            + "', vremepolaska:'" + l.vremepolaska + "', vremeletenja:'" + l.vremeletenja 
                                                            + "', brojsedista:'" + l.brojsedista 
                                                            + "', osnovnacena:'" + l.osnovnacena + "'}) return n",
                                                            queryDict, CypherResultMode.Set);

            ((IRawGraphClient)client).ExecuteGetCypherResults<Let>(query);
        }
        public static Let GetLet(int id)
        {
            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            queryDict.Add("id", id.ToString());

            var query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) where (n:Let) and exists(n.id) and n.id = {id} return n",
                                                            queryDict, CypherResultMode.Set);

            List<Let> letovi = ((IRawGraphClient)client).ExecuteGetCypherResults<Let>(query).ToList();

            foreach (Let a in letovi)
            {
                return a;
            }

            return null;
        }
        public static List<Let> VratiSveLetove()
        {
            Dictionary<string, object> d = new Dictionary<string, object>();

            var query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) where (n:Let) return n",
                                                           d, CypherResultMode.Set);

            List<Let> letovi = ((IRawGraphClient)client).ExecuteGetCypherResults<Let>(query).ToList();

            return letovi;
        }
        public static void AzurirajLet(Let l)
        {
            var query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) where (n:Let) and exists(n.id) and n.id = '" + l.id + "'" +
                                                                " set n.datumpolaska = '" + l.datumpolaska + "'," +
                                                                " n.vremepolaska = '" + l.vremepolaska + "'," +
                                                                " n.vremeletenja = '" + l.vremeletenja + "'," +
                                                                " n.osnovnacena = '" + l.osnovnacena + "'" +
                                                                " return n",
                                                            new Dictionary<string, object>(), CypherResultMode.Set);

            List<Let> letovi = ((IRawGraphClient)client).ExecuteGetCypherResults<Let>(query).ToList();

        }
        public static void IzbrisiLet(int id)
        {
            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            queryDict.Add("id", id.ToString());

            var query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) where (n:Let) and exists(n.id) and n.id = {id} DETACH delete n",
                                                            queryDict, CypherResultMode.Projection);

            List<Let> letovi = ((IRawGraphClient)client).ExecuteGetCypherResults<Let>(query).ToList();

        }
        public static List<Let> PronadjiLetove(string datumpolaska)
        {
            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            queryDict.Add("datumpolaska", datumpolaska);

            var query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) where (n:Let) and exists(n.datumpolaska) and n.datumpolaska = {datumpolaska}  return n",
                                                         queryDict, CypherResultMode.Set);

            List<Let> letovi = ((IRawGraphClient)client).ExecuteGetCypherResults<Let>(query).ToList();

            return letovi;
        }
        public static Let PronadjiLet(int id)
        {
            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            queryDict.Add("id", id.ToString());
            var query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) where (n:Let) and exists(n.id) and n.id = {id}  return n",
                                                      queryDict, CypherResultMode.Set);

            Let letovi = ((IRawGraphClient)client).ExecuteGetCypherResults<Let>(query).Single();

            return letovi;
        }
        public static void VezaLetAerodromPolazni(Let let, Aerodrom polazni)
        {
            var veza = new Neo4jClient.Cypher.CypherQuery("MATCH (l:Let), (a:Aerodrom) " +
                                                          "WHERE l.id = '" + let.id + "' AND a.id = '" + polazni.id
                                                          + "' " + "CREATE (a)<-[r:POLAZI_OD]-(l) return a",
                                                         new Dictionary<string, object>(), CypherResultMode.Set);

            List<Aerodrom> tmp = ((IRawGraphClient)client).ExecuteGetCypherResults<Aerodrom>(veza).ToList();

        }
        public static void VezaLetAerodromOdredisni(Let let, Aerodrom destinacija)
        {
            var veza = new Neo4jClient.Cypher.CypherQuery("MATCH (l:Let), (a:Aerodrom) " +
                                                         "WHERE l.id = '" + let.id + "' AND a.id = '" + destinacija.id
                                                         + "' " + "CREATE (a)<-[r:SLECE_NA]-(l) return a",
                                                        new Dictionary<string, object>(), CypherResultMode.Set);

            List<Aerodrom> tmp = ((IRawGraphClient)client).ExecuteGetCypherResults<Aerodrom>(veza).ToList();

        }
        public static void VezaLetAerodromAvion(Let let, Avion avion)
        {
            var veza = new Neo4jClient.Cypher.CypherQuery("MATCH (l:Let), (a:Avion) " +
                                                                    "WHERE l.id = '" + let.id + "' AND a.id = '" + avion.id
                                                                    + "' " + "CREATE (a)<-[r:LET_AVION]-(l) return a",
                                                                   new Dictionary<string, object>(), CypherResultMode.Set);

            List<Avion> tmp = ((IRawGraphClient)client).ExecuteGetCypherResults<Avion>(veza).ToList();

        }
        public static Aerodrom VratiPolazniAerodromLeta(Let let)
        {
            var veza = new Neo4jClient.Cypher.CypherQuery("match (l)-[:POLAZI_OD]-(a)" +
                                                        "where l.id = '" + let.id + "'return a",
                                                       new Dictionary<string, object>(), CypherResultMode.Set);

            Aerodrom tmp = ((IRawGraphClient)client).ExecuteGetCypherResults<Aerodrom>(veza).FirstOrDefault();

            return tmp;
        }
        public static Aerodrom VratiDestinacijuLeta(Let let)
        {
            var veza = new Neo4jClient.Cypher.CypherQuery("match (l)-[:SLECE_NA]-(a)" +
                                                       "where l.id = '" + let.id + "'return a",
                                                      new Dictionary<string, object>(), CypherResultMode.Set);

            Aerodrom tmp = ((IRawGraphClient)client).ExecuteGetCypherResults<Aerodrom>(veza).Single();

            return tmp;
        }
        public static void AzurirajBrojPutnikaLeta(Let let)
        {
            var query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) where (n:Let) and exists(n.id) and n.id = '" + let.id + "'" +
                                                               " set n.brojsedista = '" + let.brojsedista + "'" +                                                          
                                                               " return n",
                                                           new Dictionary<string, object>(), CypherResultMode.Set);


            List<Let> avioni = ((IRawGraphClient)client).ExecuteGetCypherResults<Let>(query).ToList();
        }
        internal static List<Let> VratiLetove(string datumPolaska, string mestoPolaska, string destinacija)
        {
            var veza = new Neo4jClient.Cypher.CypherQuery("match (:Aerodrom {mesto:'" + mestoPolaska +"'})<-[:POLAZI_OD]-(l:Let)-[:SLECE_NA]->(:Aerodrom {mesto:'" + destinacija + "'}) " +
                                                        "where l.datumpolaska = '" + datumPolaska+ "' return l",
                                                       new Dictionary<string, object>(), CypherResultMode.Set);

            List<Let> tmp = ((IRawGraphClient)client).ExecuteGetCypherResults<Let>(veza).ToList();

            return tmp;
        }

        //jos putanje!
        public static List<Let> VratiPutanjeLeta(String odakle, String dokle)
        {

            //var veza = new Neo4jClient.Cypher.CypherQuery("MATCH path = (n:Aerodrom)-[*]-(l:Aerodrom) with nodes(path) as p " +
            //                                    " where exists(n.mesto) and n.mesto = 'Nis'" +
            //                                    " and exists(l.mesto)and l.mesto = 'New York' " +
            //                                    "return [node in p where not node: Let and not node: Avion]",
            //                                           new Dictionary<string, object>(), CypherResultMode.Set);



              //IEnumerable<Node<Aerodrom>> tmp = ((IRawGraphClient)client).ExecuteGetCypherResults<IEnumerable<Node<Aerodrom>>>(veza).ToList();


            var query = client.Cypher
                       .Match("p=(pol:Aerodrom {mesto:{odakle}})-[*]-(dest:Aerodrom {mesto:{dokle}})")
                       .WithParam("odakle", odakle)
                       .WithParam("dokle", dokle)
                       .Return((p, order) => new
                       {
                            aerodromi = Return.As<IEnumerable<Node<Aerodrom>>>("nodes(p)"),
                           letovi = Return.As<IEnumerable<Node<Let>>>("nodes(p)")

                       })
                       .Limit(1);

            var result = query.Results;

            List<Let> letovi = new List<Let>(); 

            foreach (var res in result)
            {


                //foreach (var city in res.aerodromi.ToList())
                //{
                //    if (city.Data.mesto != null)
                //    {
                //        MessageBox.Show(city.Data.mesto);
                //    }
                //};

                foreach (var let in res.letovi.ToList())
                {
                    if (let.Data.datumpolaska != null && let.Data.datumpolaska == "18.12.2018")
                    {
                        Let l = new Let();
                        l = let.Data;
                        letovi.Add(l);
                       
                    }

                };

            }




            return letovi;
        }


        #endregion

        #region Metode za aerodrome

        public static void DodajAerodrom(Aerodrom a)
        {
            int noviId = Int32.Parse(getMaxId()) + 1;

            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            queryDict.Add("id", noviId.ToString());
            queryDict.Add("mesto", a.mesto);
            queryDict.Add("kapacitet", a.kapacitet);

            var query = new Neo4jClient.Cypher.CypherQuery("CREATE (n:Aerodrom {id:'" + noviId + "', mesto:'" + a.mesto
                                                            + "', kapacitet:'" + a.kapacitet + "'}) return n",
                                                            queryDict, CypherResultMode.Set);

            ((IRawGraphClient)client).ExecuteGetCypherResults<Aerodrom>(query);
        }
        public static Aerodrom GetAerodrom(int id)
        {
            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            queryDict.Add("id", id.ToString());

            var query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) where (n:Aerodrom) and exists(n.id) and n.id = {id} return n",
                                                            queryDict, CypherResultMode.Set);

            List<Aerodrom> aerodromi = ((IRawGraphClient)client).ExecuteGetCypherResults<Aerodrom>(query).ToList();

            foreach (Aerodrom a in aerodromi)
            {
                return a;
            }

            return null;
        }
        public static List<Aerodrom> VratiSveAerodrome()
        {
            Dictionary<string, object> d = new Dictionary<string, object>();

            var query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) where (n:Aerodrom) return n",
                                                           d, CypherResultMode.Set);

            List<Aerodrom> aerodromi = ((IRawGraphClient)client).ExecuteGetCypherResults<Aerodrom>(query).ToList();

            return aerodromi;
        }
        public static void AzurirajAerodrom(Aerodrom a)
        {
            var query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) where (n:Aerodrom) and exists(n.id) and n.id = '" + a.id + "'" +
                                                                " set n.mesto = '" + a.mesto + "'," +
                                                                " n.kapacitet = '" + a.kapacitet + "'" +
                                                                " return n",
                                                            new Dictionary<string, object>(), CypherResultMode.Set);

            List<Aerodrom> aerodromi = ((IRawGraphClient)client).ExecuteGetCypherResults<Aerodrom>(query).ToList();

        }
        public static void IzbrisiAerodrom(int id)
        {
            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            queryDict.Add("id", id.ToString());

            var query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) where (n:Aerodrom) and exists(n.id) and n.id = {id} DETACH delete n",
                                                            queryDict, CypherResultMode.Projection);

            List<Aerodrom> aerodromi = ((IRawGraphClient)client).ExecuteGetCypherResults<Aerodrom>(query).ToList();
        }


        #endregion

        #region Metode za karte i putnike

        public static void DodajPutnika(Putnik p)
        {
            Dictionary<string, object> dictP = new Dictionary<string, object>();
            dictP.Add("ime", p.ime);
            dictP.Add("prezime", p.prezime);
            dictP.Add("pasos", p.pasos);



            var query = new Neo4jClient.Cypher.CypherQuery("CREATE (n:Putnik {id:'" + p.id + "', ime:'" + p.ime
                                                            + "', prezime:'" + p.prezime + "', pasos:'" + p.pasos
                                                            + "'}) return n",
                                                            dictP, CypherResultMode.Set);

            Putnik tm = ((IRawGraphClient)client).ExecuteGetCypherResults<Putnik>(query).Single();
        }    
        internal static void VezaKartaLet(Karta karta, Let let)
        {
            var veza = new Neo4jClient.Cypher.CypherQuery("MATCH (l:Let), (k:Karta) " +
                                                           "WHERE l.id = '" + let.id + "' AND k.id = '" + karta.id
                                                           + "' " + "CREATE (l)<-[r:REZERVISANA_NA_LETU]-(k) return l",
                                                          new Dictionary<string, object>(), CypherResultMode.Set);

            List<Let> tmp = ((IRawGraphClient)client).ExecuteGetCypherResults<Let>(veza).ToList();
        }
        public static void DodajKartu(Karta karta)
        { 
            Dictionary<string, object> dictK = new Dictionary<string, object>();
            dictK.Add("cena", karta.cena);
            dictK.Add("klasa", karta.klasa);
            dictK.Add("velicinaprtljaga", karta.velicinaprtljaga);
            dictK.Add("brojsedista", karta.brojsedista);

            var query = new Neo4jClient.Cypher.CypherQuery("CREATE (n:Karta {id:'" + karta.id + "', cena:'" + karta.cena
                                                            + "', klasa:'" + karta.klasa
                                                            + "', brojsedista:'" + karta.brojsedista
                                                            + "', velicinaprtljaga:'" + karta.velicinaprtljaga
                                                            + "'}) return n",
                                                            dictK, CypherResultMode.Set);

            List<Karta> k = ((IRawGraphClient)client).ExecuteGetCypherResults<Karta>(query).ToList();
        }
        public static void VezaKartaPutnik(Karta karta, Putnik putnik)
        {
            var veza = new Neo4jClient.Cypher.CypherQuery("MATCH (p:Putnik), (k:Karta) " +
                                                           "WHERE p.id = '" + putnik.id + "' AND k.id = '" + karta.id
                                                           + "' " + "CREATE (p)<-[r:POSEDUJE]-(k) return p",
                                                          new Dictionary<string, object>(), CypherResultMode.Set);

            List<Putnik> tmp = ((IRawGraphClient)client).ExecuteGetCypherResults<Putnik>(veza).ToList();
        }
        public static List<Karta> VratiKartePutnika(Putnik p)
        {
            var veza = new Neo4jClient.Cypher.CypherQuery("match (n)-[:POSEDUJE]-(k) " +
                                                          "where n.id = '" + p.id + "'return k",
                                                         new Dictionary<string, object>(), CypherResultMode.Set);

            List<Karta> tmp = ((IRawGraphClient)client).ExecuteGetCypherResults<Karta>(veza).ToList();

            return tmp;
        }
        public static List<Putnik> VratiVlasnikaKarte(Karta k)
        {
            var veza = new Neo4jClient.Cypher.CypherQuery("match (n)-[:POSEDUJE]-(k) " +
                                                         "where n.id = '" + k.id + "'return n",
                                                        new Dictionary<string, object>(), CypherResultMode.Set);

            List<Putnik> tmp = ((IRawGraphClient)client).ExecuteGetCypherResults<Putnik>(veza).ToList();

            return tmp;
        }
        public static List<Let> VratiLetPutnika(Putnik p)
        {
            var veza = new Neo4jClient.Cypher.CypherQuery("match (p)-[:POSEDUJE]-(k)-[:REZERVISANA_NA_LETU]-(l) " +
                                                         "where p.id = '" + p.id + "'return l",
                                                        new Dictionary<string, object>(), CypherResultMode.Set);

            List<Let> tmp = ((IRawGraphClient)client).ExecuteGetCypherResults<Let>(veza).ToList();

            return tmp;
        }
        public static Putnik VratiPutnika(int id)
        {

            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            queryDict.Add("id", id.ToString());
            var query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) where (n:Putnik) and exists(n.id) and n.id = {id}  return n",
                                                      queryDict, CypherResultMode.Set);

            Putnik putnik = ((IRawGraphClient)client).ExecuteGetCypherResults<Putnik>(query).Single();

            return putnik;

        }
        public static void IzbrisiPutnika(Putnik p)
        {
            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            queryDict.Add("id", p.id);

            var query = new Neo4jClient.Cypher.CypherQuery("match (n) where (n:Putnik) and exists(n.id)" +
                                                           " and n.id = {id} detach delete n",
                                                            queryDict, CypherResultMode.Projection);

            List<Putnik> u = ((IRawGraphClient)client).ExecuteGetCypherResults<Putnik>(query).ToList();
        }       
        public static List<Putnik> VratiPutnikeLeta(Let let)
        {
            var veza = new Neo4jClient.Cypher.CypherQuery("match (p:Putnik)-[:POSEDUJE]-(k:Karta)-[:REZERVISANA_NA_LETU]-(l:Let)" +
                                                        "where l.id = '" + let.id + "'return p",
                                                       new Dictionary<string, object>(), CypherResultMode.Set);

            List<Putnik> putnici = ((IRawGraphClient)client).ExecuteGetCypherResults<Putnik>(veza).ToList();

            return putnici;         
        }

        #endregion

        #region Metode za korisnike

        public static User VratiKorisnika(String korisnicko, String sifra)
        {
            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            queryDict.Add("korisnicko", korisnicko);
            queryDict.Add("sifra", sifra);

            var query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) where (n:User) and exists(n.korisnicko) and exists(n.sifra) and n.sifra={sifra} and n.korisnicko = {korisnicko}  return n",
                                                          queryDict, CypherResultMode.Set);

            User user = ((IRawGraphClient)client).ExecuteGetCypherResults<User>(query).FirstOrDefault();

            return user;
        }
        public static void DodajKorisnika(User user)
        {
            Dictionary<string, object> dictU = new Dictionary<string, object>();
            dictU.Add("ime", user.ime);
            dictU.Add("prezime", user.prezime);
            dictU.Add("korisnicko", user.korisnicko);
            dictU.Add("sifra", user.sifra);
            dictU.Add("a", user.a);


            var query = new Neo4jClient.Cypher.CypherQuery("CREATE (n:User {id:'" + user.id + "', ime:'" + user.ime
                                                           + "', prezime:'" + user.prezime + "', korisnicko:'" + user.korisnicko
                                                           + "', sifra:'" + user.sifra + "', a:'" + user.a
                                                           + "'}) return n",
                                                           dictU, CypherResultMode.Set);

            User tm = ((IRawGraphClient)client).ExecuteGetCypherResults<User>(query).Single();

        }
        public static bool PostojiKorisnik(String korisnicko)
        {
            
            var query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) where (n:User) and exists(n.korisnicko) " +
                                                            "and n.korisnicko = '" + korisnicko + "'  return n",
                                                         new Dictionary<string, object>(), CypherResultMode.Set);

            User user = ((IRawGraphClient)client).ExecuteGetCypherResults<User>(query).FirstOrDefault();

            if (user == null)
                return false;

            return true;
        }
        public static void AzurirajKorisnika(User user)
        {
            var query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) where (n:User) and exists(n.id) and n.id = '" + user.id + "'" +
                                                                " set n.ime = '" + user.ime + "'," +
                                                                " n.prezime = '" + user.prezime + "'," +
                                                                " n.korisnicko = '" + user.korisnicko + "'," +
                                                                " n.sifra = '" + user.sifra + "'" +
                                                                " return n",
                                                            new Dictionary<string, object>(), CypherResultMode.Set);

            User u = ((IRawGraphClient)client).ExecuteGetCypherResults<User>(query).Single();
        }
        public static List<User> VratiSveRadnike()
        {
            var query = new Neo4jClient.Cypher.CypherQuery("match(n) where (n:User) return n",
                                                      new Dictionary<string, object>(), CypherResultMode.Set);

            List<User> tmp = ((IRawGraphClient)client).ExecuteGetCypherResults<User>(query).ToList();

            return tmp;
        }
        public static void OtpustiRadnika(User user)
        {
            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            queryDict.Add("id", user.id);

            var query = new Neo4jClient.Cypher.CypherQuery("match (n) where (n:User) and exists(n.id)" +
                                                           " and n.id = {id} detach delete n",
                                                            queryDict, CypherResultMode.Projection);

            List<User> u = ((IRawGraphClient)client).ExecuteGetCypherResults<User>(query).ToList();
        }
        public static User VratiKorisnika(int id)
        {
            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            queryDict.Add("id", id.ToString());
            var query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) where (n:User) and exists(n.id) and n.id = {id}  return n",
                                                      queryDict, CypherResultMode.Set);

            User user = ((IRawGraphClient)client).ExecuteGetCypherResults<User>(query).Single();

            return user;
        }

        #endregion


        public static String getMaxId()
        {
            var query = new Neo4jClient.Cypher.CypherQuery("match (n) return max(n.id)",
                                                            new Dictionary<string, object>(), CypherResultMode.Set);

            String maxId = ((IRawGraphClient)client).ExecuteGetCypherResults<String>(query).ToList().FirstOrDefault();

            if (maxId == null)
            {
                return "10"; //id pocinje od 10 pa navise
            }
            return maxId;
        }
        public static void Povezivanje()
        {
            client = new GraphClient(new Uri("http://localhost:7474/db/data"), "neo4j", "avioprevoznik");
            try
            {
                client.Connect();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
