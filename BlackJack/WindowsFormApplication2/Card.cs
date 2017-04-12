using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    public class Card
    {
            private int rank;
            private int suite;

            public Card(int s, int r)
            {
                rank = r;
                suite = s;
            }

            public int dealSum()
            {
                int rankTotal = rank;

                switch (rankTotal)
                {
                    case 0:
                        rankTotal = 11;
                        break;
                    case 11:
                        rankTotal = 10;
                        break;
                    case 12:
                        rankTotal = 10;
                        break;
                    default:
                        rankTotal = rank;
                        break;
                }

                return rankTotal;
            }

            public String toSuite()
            {
                String s;
                switch (suite)
                {
                    case 0:
                        s = " |♥";
                        break;
                    case 1:
                        s = " |♦";
                        break;
                    case 2:
                        s = " |♠";
                        break;
                    case 3:
                        s = " |♣";
                        break;
                    default:
                        s = "";
                        break;
                }

                s = s + " ";
                switch (rank)
                {
                    case 0:
                        s = s + "A|";
                        break;
                    case 10:
                        s = s + "J|";
                        break;
                    case 11:
                        s = s + "Q|";
                        break;
                    case 12:
                        s = s + "K|";
                        break;
                    default:
                        s = s + rank + "|";
                        break;
                }
                return s;
            }
        }
}
