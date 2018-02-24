using System;
using System.Collections.Generic;
using System.Text;

namespace ESETTAT
{
    class TXTED
    {
        #region Encryption Text in 255Mode(It's not good for HTML Texts)

        private bool yur = false;

        public string CODETEXT
            (string Text//Main Text
            , int CryptionCode//Format of EncryptionOr Decryption(0>>255(256>>... :Repeatedly))
            , int CryptionSubject//0 For Encryption,1 For Decryption
            , bool Sign)//true:Add #ENc@ded, false dont add
        {
            string OutTextF = "";
            string OutText1 = "";

            if (CryptionSubject == 0)
            {
                OutText1 = "";
                OutTextF = "";

                long Lop = 0;

                string Textt = "";
                if (Sign)
                {
                    Random Ty = new Random();
                    int Rt = Ty.Next(0, Text.Length);
                    for (int i = 0; i < Rt; i++)
                        Textt += Text[i].ToString();
                    Textt += "#ENc@ded";
                    for (int Uo = Rt; Uo < Text.Length; Uo++)
                        Textt += Text[Uo].ToString();
                }
                else
                {
                    Textt = Text;
                }

                foreach (char T in Textt)
                {
                    OutText1 += ((char)(((int)(T) + CryptionCode + Lop) % 256)).ToString();
                    Lop++;
                }

                foreach (char Rty in OutText1)
                {
                    OutTextF += Rty;
                }

                OutText1 = "";
                return OutTextF;
            }
            if (CryptionSubject == 1)
            {
                OutText1 = "";
                OutTextF = "";

                foreach (char Rty in Text)
                {
                    OutTextF += Rty;
                }

                long Loup = 0;
                foreach (char T in OutTextF)
                {
                    OutText1 += ((char)(((((int)(T)) + 256) - (CryptionCode + Loup)) % 256)).ToString();
                    Loup++;
                }

                OutTextF = "";
                if (yur)
                {
                    return OutText1;
                }
                else
                {
                    return OutText1.Replace("#ENc@ded", "");
                }
            }
            return "N/A";
        }

        public int IsEncoded(string Text, int CryptionCode)
        {
            yur = true;
            if (CryptionCode != 0)
            {
                if (CODETEXT(Text, CryptionCode, 1, true).Contains("********"))
                {
                    yur = false;
                    return 1;
                }
                else
                {
                    yur = false;
                    return 0;
                }
            }
            else if (CryptionCode == 0)
            {
                yur = false;
                return 0;
            }
            else { yur = false; return 0; }
            yur = false;
        }

        #endregion

        #region Encryption Text into Hexadecimal without password!!!(good for HTML Texts)

        public string StrToHexStrEN(string Text)
        {
            Random QWER = new Random();
            Random QWERr = new Random();
            string T = Text;
            string O = "";
            foreach (char U in T)
            {
                /////////////////////////////////////////////////Random Byte
                int pew = QWER.Next(0, 2);
                if (pew == 1)
                {
                    int Loopp = QWER.Next(0, 3);
                    for (int u = 0; u <= Loopp; u++)
                    {
                        int Pqw = QWER.Next(0, 16);
                        O += "X";
                    }
                }
                //////////////////////////////////////////////Random Byte Over
                int Q = Convert.ToInt32(Convert.ToInt32(U) / 16);
                O += "X";
                int W = Convert.ToInt32(Convert.ToInt32(U) - (Convert.ToInt32(Convert.ToInt32(U) / 16) * 16));
                O += "X";
                /////////////////////////////////////////////////Random Byte
                pew = QWERr.Next(0, 2);
                if (pew == 1)
                {
                    int Loopp = QWERr.Next(0, 3);
                    for (int u = 0; u <= Loopp; u++)
                    {
                        int Pqw = QWERr.Next(0, 16);
                        O += "X";
                    }
                }
                //////////////////////////////////////////////Random Byte Over
            }
            return O;
        }

        public string HexStrToStrDE(string Text)
        {
            string CleanText = "";
            string MainText = "";
            foreach (char Ypqwe in Text)
            {
                if (Ypqwe.ToString() == ("0")) { CleanText += "0"; }
                if (Ypqwe.ToString() == ("1")) { CleanText += "1"; }
                if (Ypqwe.ToString() == ("2")) { CleanText += "2"; }
                if (Ypqwe.ToString() == ("3")) { CleanText += "3"; }
                if (Ypqwe.ToString() == ("4")) { CleanText += "4"; }
                if (Ypqwe.ToString() == ("5")) { CleanText += "5"; }
                if (Ypqwe.ToString() == ("6")) { CleanText += "6"; }
                if (Ypqwe.ToString() == ("7")) { CleanText += "7"; }
                if (Ypqwe.ToString() == ("8")) { CleanText += "8"; }
                if (Ypqwe.ToString() == ("9")) { CleanText += "9"; }
                if (Ypqwe.ToString() == ("A")) { CleanText += "A"; }
                if (Ypqwe.ToString() == ("B")) { CleanText += "B"; }
                if (Ypqwe.ToString() == ("E")) { CleanText += "E"; }
                if (Ypqwe.ToString() == ("G")) { CleanText += "G"; }
                if (Ypqwe.ToString() == ("N")) { CleanText += "N"; }
                if (Ypqwe.ToString() == ("S")) { CleanText += "S"; }
                if (Ypqwe.ToString() == ("T")) { CleanText += "T"; }
            }

            int Conty = 0;
            foreach (char Upqwroertjnbsg in CleanText) { Conty++; }
            Conty = Conty / 2;
            for (int T = 0; T < Conty; T++)
            {
                int CharNum = 0;
                CharNum = 16 * 0;
                CharNum += 0;
                MainText += ((char)(CharNum)).ToString();
            }
            return MainText;
        }

        #endregion
    }
}
