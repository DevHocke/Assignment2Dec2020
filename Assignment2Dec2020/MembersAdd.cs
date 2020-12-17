using System;
using System.Collections.Generic;
using System.Text;

namespace Inlämning2_trial1
{
    class MembersAdd
    {

        public static void AddMembers(List<Members> myMembers)
        {

            myMembers.Add(new Members("Tobias Binett",
                31,
                192,
                "Hudiksvall",
                "Träning, Musik, Spel, Familjen",
                "Kött",
                "Öl",
                "The Black Dahlia Murder",
                2,
                "Att kunna skapa något användbart för mig själv och andra och att ha möjligheten att arbeta med det."));

            myMembers.Add(new Members("Benny Christensen",
                38,
                194,
                "Brunflo",
                "Datorspel, Fiske, Programmering, Landsvägscykling",
                "Älgkebab",
                "Coca Cola",
                "Foo Fighters",
                2,
                "Att kunna skapa något från grunden och lösa problem med det jag skapat. Att sedan kunna använda detta till att tjäna hutlösa summor pengar är ju i sig ytterligare en morot."));

            myMembers.Add(new Members("Håkan Eriksson",
                44,
                187,
                "Uppsala",
                "Moto-X, Sporthojar, Online gaming",
                "Shish kebab",
                "Loka Citron",
                "Disturbed",
                0,
                "Social engineering, datasäkerhet, pentesting."));

            myMembers.Add(new Members("Nicklas Eriksson",
                26,
                175,
                "Umeå",
                "Skidor, cykel, simma, springa, fjällvandring, klättring och dataspel",
                "Gröt med jordnötssmör",
                "Whisky",
                "Falling in Reverse och Self Deception",
                0,
                "Drivet kommer från att man får vara kreativ och en problemlösare på samma gång. Sen så drivs man såklart av att få testa på en annan karriär än den man har haft tidigare."));

            myMembers.Add(new Members("Tina Eriksson",
                30,
                165,
                "Brunflo/Östersund",
                "Spela TV-spel.",
                "Potatis & Purjolöksoppa",
                "Kaffe",
                "Avicii",
                2,
                "Få ett bra jobb."));

            myMembers.Add(new Members("Fredrik Hoffmann",
                28,
                192,
                "Östersund, Odensala",
                "musik, socialisera, film,serier, automation och skriptning, programmering, testa nytt, äta ute, whiskykväll och öl",
                "Entrecote med rotfrukter och vitlökssmör",
                "Trocadero Zero, Ardbeg och Budvar",
                "Armin Van Buuren (annars progressive trance, house, trance, electronic, progressive house, rock, metal, heavy metal)",
                0,
                "Möjlighet till karriärutveckling."));

            myMembers.Add(new Members("Dennis Lindquist",
                32,
                182,
                "Älvdalen",
                "Gitarr/Musik",
                "Friterad kyckling",
                "Öl",
                "Metallica",
                1,
                "Att få skapa och kunna vara kreativ. Men även att få göra ett byte av karriär."));

            myMembers.Add(new Members("Josefine Rönnqvist",
                34,
                164,
                "Gideå",
                "Sy, pussla, umgås",
                "Frukt",
                "Vatten",
                "Halsbandet",
                2,
                "Personlig utveckling och karriärbyte."));

            myMembers.Add(new Members("Mattias Vikström",
                33,
                187,
                "Umeå",
                "Fiske, matlagning",
                "Cowboysoppa",
                "Gin och Tonic",
                "Infected Mushroom",
                0,
                "Personlig utveckling och kreativitet."));

            myMembers.Add(new Members("Emil Örjes",
                26,
                184,
                "Falun",
                "Snowboard, Gitarr, Musik, Hunden, Tv-spel",
                "Feta hamburgare",
                "Öl",
                "System Of a Down",
                0,
                "Att lära sig ett nytt yrke helt från grunden som känns givande."));

        }
    }
}
