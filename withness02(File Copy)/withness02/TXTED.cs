using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace withness02
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
                    switch ((int)(Rty))
                    {
                        case 0:
                            OutTextF += (char)(41);
                            break;
                        case 1:
                            OutTextF += (char)(70);
                            break;
                        case 2:
                            OutTextF += (char)(154);
                            break;
                        case 3:
                            OutTextF += (char)(50);
                            break;
                        case 4:
                            OutTextF += (char)(33);
                            break;
                        case 5:
                            OutTextF += (char)(206);
                            break;
                        case 6:
                            OutTextF += (char)(87);
                            break;
                        case 7:
                            OutTextF += (char)(93);
                            break;
                        case 8:
                            OutTextF += (char)(23);
                            break;
                        case 9:
                            OutTextF += (char)(123);
                            break;
                        case 10:
                            OutTextF += (char)(29);
                            break;
                        case 11:
                            OutTextF += (char)(13);
                            break;
                        case 12:
                            OutTextF += (char)(241);
                            break;
                        case 13:
                            OutTextF += (char)(124);
                            break;
                        case 14:
                            OutTextF += (char)(172);
                            break;
                        case 15:
                            OutTextF += (char)(171);
                            break;
                        case 16:
                            OutTextF += (char)(24);
                            break;
                        case 17:
                            OutTextF += (char)(97);
                            break;
                        case 18:
                            OutTextF += (char)(142);
                            break;
                        case 19:
                            OutTextF += (char)(133);
                            break;
                        case 20:
                            OutTextF += (char)(225);
                            break;
                        case 21:
                            OutTextF += (char)(30);
                            break;
                        case 22:
                            OutTextF += (char)(59);
                            break;
                        case 23:
                            OutTextF += (char)(100);
                            break;
                        case 24:
                            OutTextF += (char)(178);
                            break;
                        case 25:
                            OutTextF += (char)(251);
                            break;
                        case 26:
                            OutTextF += (char)(173);
                            break;
                        case 27:
                            OutTextF += (char)(197);
                            break;
                        case 28:
                            OutTextF += (char)(16);
                            break;
                        case 29:
                            OutTextF += (char)(193);
                            break;
                        case 30:
                            OutTextF += (char)(158);
                            break;
                        case 31:
                            OutTextF += (char)(26);
                            break;
                        case 32:
                            OutTextF += (char)(200);
                            break;
                        case 33:
                            OutTextF += (char)(216);
                            break;
                        case 34:
                            OutTextF += (char)(36);
                            break;
                        case 35:
                            OutTextF += (char)(78);
                            break;
                        case 36:
                            OutTextF += (char)(53);
                            break;
                        case 37:
                            OutTextF += (char)(208);
                            break;
                        case 38:
                            OutTextF += (char)(169);
                            break;
                        case 39:
                            OutTextF += (char)(194);
                            break;
                        case 40:
                            OutTextF += (char)(107);
                            break;
                        case 41:
                            OutTextF += (char)(72);
                            break;
                        case 42:
                            OutTextF += (char)(81);
                            break;
                        case 43:
                            OutTextF += (char)(90);
                            break;
                        case 44:
                            OutTextF += (char)(244);
                            break;
                        case 45:
                            OutTextF += (char)(91);
                            break;
                        case 46:
                            OutTextF += (char)(211);
                            break;
                        case 47:
                            OutTextF += (char)(191);
                            break;
                        case 48:
                            OutTextF += (char)(89);
                            break;
                        case 49:
                            OutTextF += (char)(18);
                            break;
                        case 50:
                            OutTextF += (char)(39);
                            break;
                        case 51:
                            OutTextF += (char)(95);
                            break;
                        case 52:
                            OutTextF += (char)(110);
                            break;
                        case 53:
                            OutTextF += (char)(210);
                            break;
                        case 54:
                            OutTextF += (char)(152);
                            break;
                        case 55:
                            OutTextF += (char)(7);
                            break;
                        case 56:
                            OutTextF += (char)(186);
                            break;
                        case 57:
                            OutTextF += (char)(126);
                            break;
                        case 58:
                            OutTextF += (char)(242);
                            break;
                        case 59:
                            OutTextF += (char)(179);
                            break;
                        case 60:
                            OutTextF += (char)(102);
                            break;
                        case 61:
                            OutTextF += (char)(60);
                            break;
                        case 62:
                            OutTextF += (char)(63);
                            break;
                        case 63:
                            OutTextF += (char)(180);
                            break;
                        case 64:
                            OutTextF += (char)(116);
                            break;
                        case 65:
                            OutTextF += (char)(121);
                            break;
                        case 66:
                            OutTextF += (char)(248);
                            break;
                        case 67:
                            OutTextF += (char)(105);
                            break;
                        case 68:
                            OutTextF += (char)(170);
                            break;
                        case 69:
                            OutTextF += (char)(82);
                            break;
                        case 70:
                            OutTextF += (char)(237);
                            break;
                        case 71:
                            OutTextF += (char)(223);
                            break;
                        case 72:
                            OutTextF += (char)(11);
                            break;
                        case 73:
                            OutTextF += (char)(128);
                            break;
                        case 74:
                            OutTextF += (char)(177);
                            break;
                        case 75:
                            OutTextF += (char)(228);
                            break;
                        case 76:
                            OutTextF += (char)(182);
                            break;
                        case 77:
                            OutTextF += (char)(139);
                            break;
                        case 78:
                            OutTextF += (char)(56);
                            break;
                        case 79:
                            OutTextF += (char)(201);
                            break;
                        case 80:
                            OutTextF += (char)(239);
                            break;
                        case 81:
                            OutTextF += (char)(67);
                            break;
                        case 82:
                            OutTextF += (char)(117);
                            break;
                        case 83:
                            OutTextF += (char)(134);
                            break;
                        case 84:
                            OutTextF += (char)(32);
                            break;
                        case 85:
                            OutTextF += (char)(245);
                            break;
                        case 86:
                            OutTextF += (char)(151);
                            break;
                        case 87:
                            OutTextF += (char)(127);
                            break;
                        case 88:
                            OutTextF += (char)(255);
                            break;
                        case 89:
                            OutTextF += (char)(55);
                            break;
                        case 90:
                            OutTextF += (char)(229);
                            break;
                        case 91:
                            OutTextF += (char)(213);
                            break;
                        case 92:
                            OutTextF += (char)(4);
                            break;
                        case 93:
                            OutTextF += (char)(40);
                            break;
                        case 94:
                            OutTextF += (char)(199);
                            break;
                        case 95:
                            OutTextF += (char)(204);
                            break;
                        case 96:
                            OutTextF += (char)(159);
                            break;
                        case 97:
                            OutTextF += (char)(49);
                            break;
                        case 98:
                            OutTextF += (char)(34);
                            break;
                        case 99:
                            OutTextF += (char)(129);
                            break;
                        case 100:
                            OutTextF += (char)(195);
                            break;
                        case 101:
                            OutTextF += (char)(71);
                            break;
                        case 102:
                            OutTextF += (char)(203);
                            break;
                        case 103:
                            OutTextF += (char)(176);
                            break;
                        case 104:
                            OutTextF += (char)(190);
                            break;
                        case 105:
                            OutTextF += (char)(86);
                            break;
                        case 106:
                            OutTextF += (char)(73);
                            break;
                        case 107:
                            OutTextF += (char)(254);
                            break;
                        case 108:
                            OutTextF += (char)(148);
                            break;
                        case 109:
                            OutTextF += (char)(14);
                            break;
                        case 110:
                            OutTextF += (char)(84);
                            break;
                        case 111:
                            OutTextF += (char)(52);
                            break;
                        case 112:
                            OutTextF += (char)(113);
                            break;
                        case 113:
                            OutTextF += (char)(118);
                            break;
                        case 114:
                            OutTextF += (char)(164);
                            break;
                        case 115:
                            OutTextF += (char)(198);
                            break;
                        case 116:
                            OutTextF += (char)(188);
                            break;
                        case 117:
                            OutTextF += (char)(45);
                            break;
                        case 118:
                            OutTextF += (char)(175);
                            break;
                        case 119:
                            OutTextF += (char)(28);
                            break;
                        case 120:
                            OutTextF += (char)(147);
                            break;
                        case 121:
                            OutTextF += (char)(112);
                            break;
                        case 122:
                            OutTextF += (char)(233);
                            break;
                        case 123:
                            OutTextF += (char)(35);
                            break;
                        case 124:
                            OutTextF += (char)(114);
                            break;
                        case 125:
                            OutTextF += (char)(10);
                            break;
                        case 126:
                            OutTextF += (char)(209);
                            break;
                        case 127:
                            OutTextF += (char)(98);
                            break;
                        case 128:
                            OutTextF += (char)(145);
                            break;
                        case 129:
                            OutTextF += (char)(103);
                            break;
                        case 130:
                            OutTextF += (char)(74);
                            break;
                        case 131:
                            OutTextF += (char)(69);
                            break;
                        case 132:
                            OutTextF += (char)(163);
                            break;
                        case 133:
                            OutTextF += (char)(143);
                            break;
                        case 134:
                            OutTextF += (char)(183);
                            break;
                        case 135:
                            OutTextF += (char)(160);
                            break;
                        case 136:
                            OutTextF += (char)(168);
                            break;
                        case 137:
                            OutTextF += (char)(226);
                            break;
                        case 138:
                            OutTextF += (char)(214);
                            break;
                        case 139:
                            OutTextF += (char)(146);
                            break;
                        case 140:
                            OutTextF += (char)(130);
                            break;
                        case 141:
                            OutTextF += (char)(64);
                            break;
                        case 142:
                            OutTextF += (char)(1);
                            break;
                        case 143:
                            OutTextF += (char)(77);
                            break;
                        case 144:
                            OutTextF += (char)(215);
                            break;
                        case 145:
                            OutTextF += (char)(202);
                            break;
                        case 146:
                            OutTextF += (char)(125);
                            break;
                        case 147:
                            OutTextF += (char)(156);
                            break;
                        case 148:
                            OutTextF += (char)(79);
                            break;
                        case 149:
                            OutTextF += (char)(144);
                            break;
                        case 150:
                            OutTextF += (char)(238);
                            break;
                        case 151:
                            OutTextF += (char)(44);
                            break;
                        case 152:
                            OutTextF += (char)(181);
                            break;
                        case 153:
                            OutTextF += (char)(38);
                            break;
                        case 154:
                            OutTextF += (char)(231);
                            break;
                        case 155:
                            OutTextF += (char)(85);
                            break;
                        case 156:
                            OutTextF += (char)(247);
                            break;
                        case 157:
                            OutTextF += (char)(58);
                            break;
                        case 158:
                            OutTextF += (char)(6);
                            break;
                        case 159:
                            OutTextF += (char)(153);
                            break;
                        case 160:
                            OutTextF += (char)(131);
                            break;
                        case 161:
                            OutTextF += (char)(22);
                            break;
                        case 162:
                            OutTextF += (char)(166);
                            break;
                        case 163:
                            OutTextF += (char)(48);
                            break;
                        case 164:
                            OutTextF += (char)(20);
                            break;
                        case 165:
                            OutTextF += (char)(189);
                            break;
                        case 166:
                            OutTextF += (char)(75);
                            break;
                        case 167:
                            OutTextF += (char)(92);
                            break;
                        case 168:
                            OutTextF += (char)(109);
                            break;
                        case 169:
                            OutTextF += (char)(42);
                            break;
                        case 170:
                            OutTextF += (char)(3);
                            break;
                        case 171:
                            OutTextF += (char)(212);
                            break;
                        case 172:
                            OutTextF += (char)(219);
                            break;
                        case 173:
                            OutTextF += (char)(83);
                            break;
                        case 174:
                            OutTextF += (char)(232);
                            break;
                        case 175:
                            OutTextF += (char)(157);
                            break;
                        case 176:
                            OutTextF += (char)(5);
                            break;
                        case 177:
                            OutTextF += (char)(165);
                            break;
                        case 178:
                            OutTextF += (char)(218);
                            break;
                        case 179:
                            OutTextF += (char)(217);
                            break;
                        case 180:
                            OutTextF += (char)(141);
                            break;
                        case 181:
                            OutTextF += (char)(162);
                            break;
                        case 182:
                            OutTextF += (char)(155);
                            break;
                        case 183:
                            OutTextF += (char)(96);
                            break;
                        case 184:
                            OutTextF += (char)(137);
                            break;
                        case 185:
                            OutTextF += (char)(220);
                            break;
                        case 186:
                            OutTextF += (char)(25);
                            break;
                        case 187:
                            OutTextF += (char)(37);
                            break;
                        case 188:
                            OutTextF += (char)(47);
                            break;
                        case 189:
                            OutTextF += (char)(222);
                            break;
                        case 190:
                            OutTextF += (char)(240);
                            break;
                        case 191:
                            OutTextF += (char)(51);
                            break;
                        case 192:
                            OutTextF += (char)(187);
                            break;
                        case 193:
                            OutTextF += (char)(119);
                            break;
                        case 194:
                            OutTextF += (char)(253);
                            break;
                        case 195:
                            OutTextF += (char)(46);
                            break;
                        case 196:
                            OutTextF += (char)(27);
                            break;
                        case 197:
                            OutTextF += (char)(8);
                            break;
                        case 198:
                            OutTextF += (char)(138);
                            break;
                        case 199:
                            OutTextF += (char)(174);
                            break;
                        case 200:
                            OutTextF += (char)(243);
                            break;
                        case 201:
                            OutTextF += (char)(9);
                            break;
                        case 202:
                            OutTextF += (char)(192);
                            break;
                        case 203:
                            OutTextF += (char)(65);
                            break;
                        case 204:
                            OutTextF += (char)(2);
                            break;
                        case 205:
                            OutTextF += (char)(234);
                            break;
                        case 206:
                            OutTextF += (char)(111);
                            break;
                        case 207:
                            OutTextF += (char)(80);
                            break;
                        case 208:
                            OutTextF += (char)(250);
                            break;
                        case 209:
                            OutTextF += (char)(66);
                            break;
                        case 210:
                            OutTextF += (char)(150);
                            break;
                        case 211:
                            OutTextF += (char)(246);
                            break;
                        case 212:
                            OutTextF += (char)(61);
                            break;
                        case 213:
                            OutTextF += (char)(235);
                            break;
                        case 214:
                            OutTextF += (char)(115);
                            break;
                        case 215:
                            OutTextF += (char)(207);
                            break;
                        case 216:
                            OutTextF += (char)(17);
                            break;
                        case 217:
                            OutTextF += (char)(140);
                            break;
                        case 218:
                            OutTextF += (char)(106);
                            break;
                        case 219:
                            OutTextF += (char)(108);
                            break;
                        case 220:
                            OutTextF += (char)(230);
                            break;
                        case 221:
                            OutTextF += (char)(221);
                            break;
                        case 222:
                            OutTextF += (char)(136);
                            break;
                        case 223:
                            OutTextF += (char)(21);
                            break;
                        case 224:
                            OutTextF += (char)(43);
                            break;
                        case 225:
                            OutTextF += (char)(135);
                            break;
                        case 226:
                            OutTextF += (char)(12);
                            break;
                        case 227:
                            OutTextF += (char)(31);
                            break;
                        case 228:
                            OutTextF += (char)(205);
                            break;
                        case 229:
                            OutTextF += (char)(54);
                            break;
                        case 230:
                            OutTextF += (char)(224);
                            break;
                        case 231:
                            OutTextF += (char)(161);
                            break;
                        case 232:
                            OutTextF += (char)(167);
                            break;
                        case 233:
                            OutTextF += (char)(184);
                            break;
                        case 234:
                            OutTextF += (char)(185);
                            break;
                        case 235:
                            OutTextF += (char)(252);
                            break;
                        case 236:
                            OutTextF += (char)(249);
                            break;
                        case 237:
                            OutTextF += (char)(88);
                            break;
                        case 238:
                            OutTextF += (char)(0);
                            break;
                        case 239:
                            OutTextF += (char)(132);
                            break;
                        case 240:
                            OutTextF += (char)(19);
                            break;
                        case 241:
                            OutTextF += (char)(15);
                            break;
                        case 242:
                            OutTextF += (char)(149);
                            break;
                        case 243:
                            OutTextF += (char)(227);
                            break;
                        case 244:
                            OutTextF += (char)(101);
                            break;
                        case 245:
                            OutTextF += (char)(76);
                            break;
                        case 246:
                            OutTextF += (char)(68);
                            break;
                        case 247:
                            OutTextF += (char)(99);
                            break;
                        case 248:
                            OutTextF += (char)(122);
                            break;
                        case 249:
                            OutTextF += (char)(62);
                            break;
                        case 250:
                            OutTextF += (char)(120);
                            break;
                        case 251:
                            OutTextF += (char)(236);
                            break;
                        case 252:
                            OutTextF += (char)(94);
                            break;
                        case 253:
                            OutTextF += (char)(196);
                            break;
                        case 254:
                            OutTextF += (char)(57);
                            break;
                        case 255:
                            OutTextF += (char)(104);
                            break;
                    }
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
                    switch ((int)(Rty))
                    {
                        case 41:
                            OutTextF += ((char)(0)).ToString();
                            break;
                        case 70:
                            OutTextF += ((char)(1)).ToString();
                            break;
                        case 154:
                            OutTextF += ((char)(2)).ToString();
                            break;
                        case 50:
                            OutTextF += ((char)(3)).ToString();
                            break;
                        case 33:
                            OutTextF += ((char)(4)).ToString();
                            break;
                        case 206:
                            OutTextF += ((char)(5)).ToString();
                            break;
                        case 87:
                            OutTextF += ((char)(6)).ToString();
                            break;
                        case 93:
                            OutTextF += ((char)(7)).ToString();
                            break;
                        case 23:
                            OutTextF += ((char)(8)).ToString();
                            break;
                        case 123:
                            OutTextF += ((char)(9)).ToString();
                            break;
                        case 29:
                            OutTextF += ((char)(10)).ToString();
                            break;
                        case 13:
                            OutTextF += ((char)(11)).ToString();
                            break;
                        case 241:
                            OutTextF += ((char)(12)).ToString();
                            break;
                        case 124:
                            OutTextF += ((char)(13)).ToString();
                            break;
                        case 172:
                            OutTextF += ((char)(14)).ToString();
                            break;
                        case 171:
                            OutTextF += ((char)(15)).ToString();
                            break;
                        case 24:
                            OutTextF += ((char)(16)).ToString();
                            break;
                        case 97:
                            OutTextF += ((char)(17)).ToString();
                            break;
                        case 142:
                            OutTextF += ((char)(18)).ToString();
                            break;
                        case 133:
                            OutTextF += ((char)(19)).ToString();
                            break;
                        case 225:
                            OutTextF += ((char)(20)).ToString();
                            break;
                        case 30:
                            OutTextF += ((char)(21)).ToString();
                            break;
                        case 59:
                            OutTextF += ((char)(22)).ToString();
                            break;
                        case 100:
                            OutTextF += ((char)(23)).ToString();
                            break;
                        case 178:
                            OutTextF += ((char)(24)).ToString();
                            break;
                        case 251:
                            OutTextF += ((char)(25)).ToString();
                            break;
                        case 173:
                            OutTextF += ((char)(26)).ToString();
                            break;
                        case 197:
                            OutTextF += ((char)(27)).ToString();
                            break;
                        case 16:
                            OutTextF += ((char)(28)).ToString();
                            break;
                        case 193:
                            OutTextF += ((char)(29)).ToString();
                            break;
                        case 158:
                            OutTextF += ((char)(30)).ToString();
                            break;
                        case 26:
                            OutTextF += ((char)(31)).ToString();
                            break;
                        case 200:
                            OutTextF += ((char)(32)).ToString();
                            break;
                        case 216:
                            OutTextF += ((char)(33)).ToString();
                            break;
                        case 36:
                            OutTextF += ((char)(34)).ToString();
                            break;
                        case 78:
                            OutTextF += ((char)(35)).ToString();
                            break;
                        case 53:
                            OutTextF += ((char)(36)).ToString();
                            break;
                        case 208:
                            OutTextF += ((char)(37)).ToString();
                            break;
                        case 169:
                            OutTextF += ((char)(38)).ToString();
                            break;
                        case 194:
                            OutTextF += ((char)(39)).ToString();
                            break;
                        case 107:
                            OutTextF += ((char)(40)).ToString();
                            break;
                        case 72:
                            OutTextF += ((char)(41)).ToString();
                            break;
                        case 81:
                            OutTextF += ((char)(42)).ToString();
                            break;
                        case 90:
                            OutTextF += ((char)(43)).ToString();
                            break;
                        case 244:
                            OutTextF += ((char)(44)).ToString();
                            break;
                        case 91:
                            OutTextF += ((char)(45)).ToString();
                            break;
                        case 211:
                            OutTextF += ((char)(46)).ToString();
                            break;
                        case 191:
                            OutTextF += ((char)(47)).ToString();
                            break;
                        case 89:
                            OutTextF += ((char)(48)).ToString();
                            break;
                        case 18:
                            OutTextF += ((char)(49)).ToString();
                            break;
                        case 39:
                            OutTextF += ((char)(50)).ToString();
                            break;
                        case 95:
                            OutTextF += ((char)(51)).ToString();
                            break;
                        case 110:
                            OutTextF += ((char)(52)).ToString();
                            break;
                        case 210:
                            OutTextF += ((char)(53)).ToString();
                            break;
                        case 152:
                            OutTextF += ((char)(54)).ToString();
                            break;
                        case 7:
                            OutTextF += ((char)(55)).ToString();
                            break;
                        case 186:
                            OutTextF += ((char)(56)).ToString();
                            break;
                        case 126:
                            OutTextF += ((char)(57)).ToString();
                            break;
                        case 242:
                            OutTextF += ((char)(58)).ToString();
                            break;
                        case 179:
                            OutTextF += ((char)(59)).ToString();
                            break;
                        case 102:
                            OutTextF += ((char)(60)).ToString();
                            break;
                        case 60:
                            OutTextF += ((char)(61)).ToString();
                            break;
                        case 63:
                            OutTextF += ((char)(62)).ToString();
                            break;
                        case 180:
                            OutTextF += ((char)(63)).ToString();
                            break;
                        case 116:
                            OutTextF += ((char)(64)).ToString();
                            break;
                        case 121:
                            OutTextF += ((char)(65)).ToString();
                            break;
                        case 248:
                            OutTextF += ((char)(66)).ToString();
                            break;
                        case 105:
                            OutTextF += ((char)(67)).ToString();
                            break;
                        case 170:
                            OutTextF += ((char)(68)).ToString();
                            break;
                        case 82:
                            OutTextF += ((char)(69)).ToString();
                            break;
                        case 237:
                            OutTextF += ((char)(70)).ToString();
                            break;
                        case 223:
                            OutTextF += ((char)(71)).ToString();
                            break;
                        case 11:
                            OutTextF += ((char)(72)).ToString();
                            break;
                        case 128:
                            OutTextF += ((char)(73)).ToString();
                            break;
                        case 177:
                            OutTextF += ((char)(74)).ToString();
                            break;
                        case 228:
                            OutTextF += ((char)(75)).ToString();
                            break;
                        case 182:
                            OutTextF += ((char)(76)).ToString();
                            break;
                        case 139:
                            OutTextF += ((char)(77)).ToString();
                            break;
                        case 56:
                            OutTextF += ((char)(78)).ToString();
                            break;
                        case 201:
                            OutTextF += ((char)(79)).ToString();
                            break;
                        case 239:
                            OutTextF += ((char)(80)).ToString();
                            break;
                        case 67:
                            OutTextF += ((char)(81)).ToString();
                            break;
                        case 117:
                            OutTextF += ((char)(82)).ToString();
                            break;
                        case 134:
                            OutTextF += ((char)(83)).ToString();
                            break;
                        case 32:
                            OutTextF += ((char)(84)).ToString();
                            break;
                        case 245:
                            OutTextF += ((char)(85)).ToString();
                            break;
                        case 151:
                            OutTextF += ((char)(86)).ToString();
                            break;
                        case 127:
                            OutTextF += ((char)(87)).ToString();
                            break;
                        case 255:
                            OutTextF += ((char)(88)).ToString();
                            break;
                        case 55:
                            OutTextF += ((char)(89)).ToString();
                            break;
                        case 229:
                            OutTextF += ((char)(90)).ToString();
                            break;
                        case 213:
                            OutTextF += ((char)(91)).ToString();
                            break;
                        case 4:
                            OutTextF += ((char)(92)).ToString();
                            break;
                        case 40:
                            OutTextF += ((char)(93)).ToString();
                            break;
                        case 199:
                            OutTextF += ((char)(94)).ToString();
                            break;
                        case 204:
                            OutTextF += ((char)(95)).ToString();
                            break;
                        case 159:
                            OutTextF += ((char)(96)).ToString();
                            break;
                        case 49:
                            OutTextF += ((char)(97)).ToString();
                            break;
                        case 34:
                            OutTextF += ((char)(98)).ToString();
                            break;
                        case 129:
                            OutTextF += ((char)(99)).ToString();
                            break;
                        case 195:
                            OutTextF += ((char)(100)).ToString();
                            break;
                        case 71:
                            OutTextF += ((char)(101)).ToString();
                            break;
                        case 203:
                            OutTextF += ((char)(102)).ToString();
                            break;
                        case 176:
                            OutTextF += ((char)(103)).ToString();
                            break;
                        case 190:
                            OutTextF += ((char)(104)).ToString();
                            break;
                        case 86:
                            OutTextF += ((char)(105)).ToString();
                            break;
                        case 73:
                            OutTextF += ((char)(106)).ToString();
                            break;
                        case 254:
                            OutTextF += ((char)(107)).ToString();
                            break;
                        case 148:
                            OutTextF += ((char)(108)).ToString();
                            break;
                        case 14:
                            OutTextF += ((char)(109)).ToString();
                            break;
                        case 84:
                            OutTextF += ((char)(110)).ToString();
                            break;
                        case 52:
                            OutTextF += ((char)(111)).ToString();
                            break;
                        case 113:
                            OutTextF += ((char)(112)).ToString();
                            break;
                        case 118:
                            OutTextF += ((char)(113)).ToString();
                            break;
                        case 164:
                            OutTextF += ((char)(114)).ToString();
                            break;
                        case 198:
                            OutTextF += ((char)(115)).ToString();
                            break;
                        case 188:
                            OutTextF += ((char)(116)).ToString();
                            break;
                        case 45:
                            OutTextF += ((char)(117)).ToString();
                            break;
                        case 175:
                            OutTextF += ((char)(118)).ToString();
                            break;
                        case 28:
                            OutTextF += ((char)(119)).ToString();
                            break;
                        case 147:
                            OutTextF += ((char)(120)).ToString();
                            break;
                        case 112:
                            OutTextF += ((char)(121)).ToString();
                            break;
                        case 233:
                            OutTextF += ((char)(122)).ToString();
                            break;
                        case 35:
                            OutTextF += ((char)(123)).ToString();
                            break;
                        case 114:
                            OutTextF += ((char)(124)).ToString();
                            break;
                        case 10:
                            OutTextF += ((char)(125)).ToString();
                            break;
                        case 209:
                            OutTextF += ((char)(126)).ToString();
                            break;
                        case 98:
                            OutTextF += ((char)(127)).ToString();
                            break;
                        case 145:
                            OutTextF += ((char)(128)).ToString();
                            break;
                        case 103:
                            OutTextF += ((char)(129)).ToString();
                            break;
                        case 74:
                            OutTextF += ((char)(130)).ToString();
                            break;
                        case 69:
                            OutTextF += ((char)(131)).ToString();
                            break;
                        case 163:
                            OutTextF += ((char)(132)).ToString();
                            break;
                        case 143:
                            OutTextF += ((char)(133)).ToString();
                            break;
                        case 183:
                            OutTextF += ((char)(134)).ToString();
                            break;
                        case 160:
                            OutTextF += ((char)(135)).ToString();
                            break;
                        case 168:
                            OutTextF += ((char)(136)).ToString();
                            break;
                        case 226:
                            OutTextF += ((char)(137)).ToString();
                            break;
                        case 214:
                            OutTextF += ((char)(138)).ToString();
                            break;
                        case 146:
                            OutTextF += ((char)(139)).ToString();
                            break;
                        case 130:
                            OutTextF += ((char)(140)).ToString();
                            break;
                        case 64:
                            OutTextF += ((char)(141)).ToString();
                            break;
                        case 1:
                            OutTextF += ((char)(142)).ToString();
                            break;
                        case 77:
                            OutTextF += ((char)(143)).ToString();
                            break;
                        case 215:
                            OutTextF += ((char)(144)).ToString();
                            break;
                        case 202:
                            OutTextF += ((char)(145)).ToString();
                            break;
                        case 125:
                            OutTextF += ((char)(146)).ToString();
                            break;
                        case 156:
                            OutTextF += ((char)(147)).ToString();
                            break;
                        case 79:
                            OutTextF += ((char)(148)).ToString();
                            break;
                        case 144:
                            OutTextF += ((char)(149)).ToString();
                            break;
                        case 238:
                            OutTextF += ((char)(150)).ToString();
                            break;
                        case 44:
                            OutTextF += ((char)(151)).ToString();
                            break;
                        case 181:
                            OutTextF += ((char)(152)).ToString();
                            break;
                        case 38:
                            OutTextF += ((char)(153)).ToString();
                            break;
                        case 231:
                            OutTextF += ((char)(154)).ToString();
                            break;
                        case 85:
                            OutTextF += ((char)(155)).ToString();
                            break;
                        case 247:
                            OutTextF += ((char)(156)).ToString();
                            break;
                        case 58:
                            OutTextF += ((char)(157)).ToString();
                            break;
                        case 6:
                            OutTextF += ((char)(158)).ToString();
                            break;
                        case 153:
                            OutTextF += ((char)(159)).ToString();
                            break;
                        case 131:
                            OutTextF += ((char)(160)).ToString();
                            break;
                        case 22:
                            OutTextF += ((char)(161)).ToString();
                            break;
                        case 166:
                            OutTextF += ((char)(162)).ToString();
                            break;
                        case 48:
                            OutTextF += ((char)(163)).ToString();
                            break;
                        case 20:
                            OutTextF += ((char)(164)).ToString();
                            break;
                        case 189:
                            OutTextF += ((char)(165)).ToString();
                            break;
                        case 75:
                            OutTextF += ((char)(166)).ToString();
                            break;
                        case 92:
                            OutTextF += ((char)(167)).ToString();
                            break;
                        case 109:
                            OutTextF += ((char)(168)).ToString();
                            break;
                        case 42:
                            OutTextF += ((char)(169)).ToString();
                            break;
                        case 3:
                            OutTextF += ((char)(170)).ToString();
                            break;
                        case 212:
                            OutTextF += ((char)(171)).ToString();
                            break;
                        case 219:
                            OutTextF += ((char)(172)).ToString();
                            break;
                        case 83:
                            OutTextF += ((char)(173)).ToString();
                            break;
                        case 232:
                            OutTextF += ((char)(174)).ToString();
                            break;
                        case 157:
                            OutTextF += ((char)(175)).ToString();
                            break;
                        case 5:
                            OutTextF += ((char)(176)).ToString();
                            break;
                        case 165:
                            OutTextF += ((char)(177)).ToString();
                            break;
                        case 218:
                            OutTextF += ((char)(178)).ToString();
                            break;
                        case 217:
                            OutTextF += ((char)(179)).ToString();
                            break;
                        case 141:
                            OutTextF += ((char)(180)).ToString();
                            break;
                        case 162:
                            OutTextF += ((char)(181)).ToString();
                            break;
                        case 155:
                            OutTextF += ((char)(182)).ToString();
                            break;
                        case 96:
                            OutTextF += ((char)(183)).ToString();
                            break;
                        case 137:
                            OutTextF += ((char)(184)).ToString();
                            break;
                        case 220:
                            OutTextF += ((char)(185)).ToString();
                            break;
                        case 25:
                            OutTextF += ((char)(186)).ToString();
                            break;
                        case 37:
                            OutTextF += ((char)(187)).ToString();
                            break;
                        case 47:
                            OutTextF += ((char)(188)).ToString();
                            break;
                        case 222:
                            OutTextF += ((char)(189)).ToString();
                            break;
                        case 240:
                            OutTextF += ((char)(190)).ToString();
                            break;
                        case 51:
                            OutTextF += ((char)(191)).ToString();
                            break;
                        case 187:
                            OutTextF += ((char)(192)).ToString();
                            break;
                        case 119:
                            OutTextF += ((char)(193)).ToString();
                            break;
                        case 253:
                            OutTextF += ((char)(194)).ToString();
                            break;
                        case 46:
                            OutTextF += ((char)(195)).ToString();
                            break;
                        case 27:
                            OutTextF += ((char)(196)).ToString();
                            break;
                        case 8:
                            OutTextF += ((char)(197)).ToString();
                            break;
                        case 138:
                            OutTextF += ((char)(198)).ToString();
                            break;
                        case 174:
                            OutTextF += ((char)(199)).ToString();
                            break;
                        case 243:
                            OutTextF += ((char)(200)).ToString();
                            break;
                        case 9:
                            OutTextF += ((char)(201)).ToString();
                            break;
                        case 192:
                            OutTextF += ((char)(202)).ToString();
                            break;
                        case 65:
                            OutTextF += ((char)(203)).ToString();
                            break;
                        case 2:
                            OutTextF += ((char)(204)).ToString();
                            break;
                        case 234:
                            OutTextF += ((char)(205)).ToString();
                            break;
                        case 111:
                            OutTextF += ((char)(206)).ToString();
                            break;
                        case 80:
                            OutTextF += ((char)(207)).ToString();
                            break;
                        case 250:
                            OutTextF += ((char)(208)).ToString();
                            break;
                        case 66:
                            OutTextF += ((char)(209)).ToString();
                            break;
                        case 150:
                            OutTextF += ((char)(210)).ToString();
                            break;
                        case 246:
                            OutTextF += ((char)(211)).ToString();
                            break;
                        case 61:
                            OutTextF += ((char)(212)).ToString();
                            break;
                        case 235:
                            OutTextF += ((char)(213)).ToString();
                            break;
                        case 115:
                            OutTextF += ((char)(214)).ToString();
                            break;
                        case 207:
                            OutTextF += ((char)(215)).ToString();
                            break;
                        case 17:
                            OutTextF += ((char)(216)).ToString();
                            break;
                        case 140:
                            OutTextF += ((char)(217)).ToString();
                            break;
                        case 106:
                            OutTextF += ((char)(218)).ToString();
                            break;
                        case 108:
                            OutTextF += ((char)(219)).ToString();
                            break;
                        case 230:
                            OutTextF += ((char)(220)).ToString();
                            break;
                        case 221:
                            OutTextF += ((char)(221)).ToString();
                            break;
                        case 136:
                            OutTextF += ((char)(222)).ToString();
                            break;
                        case 21:
                            OutTextF += ((char)(223)).ToString();
                            break;
                        case 43:
                            OutTextF += ((char)(224)).ToString();
                            break;
                        case 135:
                            OutTextF += ((char)(225)).ToString();
                            break;
                        case 12:
                            OutTextF += ((char)(226)).ToString();
                            break;
                        case 31:
                            OutTextF += ((char)(227)).ToString();
                            break;
                        case 205:
                            OutTextF += ((char)(228)).ToString();
                            break;
                        case 54:
                            OutTextF += ((char)(229)).ToString();
                            break;
                        case 224:
                            OutTextF += ((char)(230)).ToString();
                            break;
                        case 161:
                            OutTextF += ((char)(231)).ToString();
                            break;
                        case 167:
                            OutTextF += ((char)(232)).ToString();
                            break;
                        case 184:
                            OutTextF += ((char)(233)).ToString();
                            break;
                        case 185:
                            OutTextF += ((char)(234)).ToString();
                            break;
                        case 252:
                            OutTextF += ((char)(235)).ToString();
                            break;
                        case 249:
                            OutTextF += ((char)(236)).ToString();
                            break;
                        case 88:
                            OutTextF += ((char)(237)).ToString();
                            break;
                        case 0:
                            OutTextF += ((char)(238)).ToString();
                            break;
                        case 132:
                            OutTextF += ((char)(239)).ToString();
                            break;
                        case 19:
                            OutTextF += ((char)(240)).ToString();
                            break;
                        case 15:
                            OutTextF += ((char)(241)).ToString();
                            break;
                        case 149:
                            OutTextF += ((char)(242)).ToString();
                            break;
                        case 227:
                            OutTextF += ((char)(243)).ToString();
                            break;
                        case 101:
                            OutTextF += ((char)(244)).ToString();
                            break;
                        case 76:
                            OutTextF += ((char)(245)).ToString();
                            break;
                        case 68:
                            OutTextF += ((char)(246)).ToString();
                            break;
                        case 99:
                            OutTextF += ((char)(247)).ToString();
                            break;
                        case 122:
                            OutTextF += ((char)(248)).ToString();
                            break;
                        case 62:
                            OutTextF += ((char)(249)).ToString();
                            break;
                        case 120:
                            OutTextF += ((char)(250)).ToString();
                            break;
                        case 236:
                            OutTextF += ((char)(251)).ToString();
                            break;
                        case 94:
                            OutTextF += ((char)(252)).ToString();
                            break;
                        case 196:
                            OutTextF += ((char)(253)).ToString();
                            break;
                        case 57:
                            OutTextF += ((char)(254)).ToString();
                            break;
                        case 104:
                            OutTextF += ((char)(255)).ToString();
                            break;
                    }
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
                if (CODETEXT(Text, CryptionCode, 1, true).Contains("#ENc@ded"))
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
                        switch (Pqw)
                        {//D    F   H   I   J   K   M   O   P   Q   R   V   W   X   Y   Z
                            case 0:
                                O += "D";
                                break;
                            case 1:
                                O += "F";
                                break;
                            case 2:
                                O += "H";
                                break;
                            case 3:
                                O += "I";
                                break;
                            case 4:
                                O += "J";
                                break;
                            case 5:
                                O += "K";
                                break;
                            case 6:
                                O += "M";
                                break;
                            case 7:
                                O += "O";
                                break;
                            case 8:
                                O += "P";
                                break;
                            case 9:
                                O += "Q";
                                break;
                            case 10:
                                O += "R";
                                break;
                            case 11:
                                O += "V";
                                break;
                            case 12:
                                O += "W";
                                break;
                            case 13:
                                O += "X";
                                break;
                            case 14:
                                O += "Y";
                                break;
                            case 15:
                                O += "Z";
                                break;
                            default:
                                break;
                        }
                    }
                }
                //////////////////////////////////////////////Random Byte Over
                int Q = Convert.ToInt32(Convert.ToInt32(U) / 16);
                switch (Q)
                {
                    case 0: //S
                        O += "S";
                        break;
                    case 1: //6
                        O += "6";
                        break;
                    case 2: //0
                        O += "0";
                        break;
                    case 3: //2
                        O += "2";
                        break;
                    case 4: //N
                        O += "N";
                        break;
                    case 5: //T
                        O += "T";
                        break;
                    case 6: //B
                        O += "B";
                        break;
                    case 7: //4
                        O += "4";
                        break;
                    case 8: //8
                        O += "8";
                        break;
                    case 9: //E
                        O += "E";
                        break;
                    case 10://1
                        O += "1";
                        break;
                    case 11://G
                        O += "G";
                        break;
                    case 12://5
                        O += "5";
                        break;
                    case 13://3
                        O += "3";
                        break;
                    case 14://9
                        O += "9";
                        break;
                    case 15://7
                        O += "7";
                        break;
                    case 16://A
                        O += "A";
                        break;
                    default:
                        break;
                }
                int W = Convert.ToInt32(Convert.ToInt32(U) - (Convert.ToInt32(Convert.ToInt32(U) / 16) * 16));
                switch (W)
                {//6	9	1	5	E	0	N	8	4	A	7	T	2	S	3	B	G
                    case 0: //
                        O += "6";
                        break;
                    case 1: //
                        O += "9";
                        break;
                    case 2: //
                        O += "1";
                        break;
                    case 3: //
                        O += "5";
                        break;
                    case 4: //
                        O += "E";
                        break;
                    case 5: //
                        O += "0";
                        break;
                    case 6: //B
                        O += "N";
                        break;
                    case 7: //4
                        O += "8";
                        break;
                    case 8: //8
                        O += "4";
                        break;
                    case 9: //E
                        O += "A";
                        break;
                    case 10://1
                        O += "7";
                        break;
                    case 11://G
                        O += "T";
                        break;
                    case 12://5
                        O += "2";
                        break;
                    case 13://3
                        O += "S";
                        break;
                    case 14://9
                        O += "3";
                        break;
                    case 15://7
                        O += "B";
                        break;
                    case 16://A
                        O += "G";
                        break;
                    default:
                        break;
                }
                /////////////////////////////////////////////////Random Byte
                pew = QWERr.Next(0, 2);
                if (pew == 1)
                {
                    int Loopp = QWERr.Next(0, 3);
                    for (int u = 0; u <= Loopp; u++)
                    {
                        int Pqw = QWERr.Next(0, 16);
                        switch (Pqw)
                        {//D    F   H   I   J   K   M   O   P   Q   R   V   W   X   Y   Z
                            case 0:
                                O += "D";
                                break;
                            case 1:
                                O += "F";
                                break;
                            case 2:
                                O += "H";
                                break;
                            case 3:
                                O += "I";
                                break;
                            case 4:
                                O += "J";
                                break;
                            case 5:
                                O += "K";
                                break;
                            case 6:
                                O += "M";
                                break;
                            case 7:
                                O += "O";
                                break;
                            case 8:
                                O += "P";
                                break;
                            case 9:
                                O += "Q";
                                break;
                            case 10:
                                O += "R";
                                break;
                            case 11:
                                O += "V";
                                break;
                            case 12:
                                O += "W";
                                break;
                            case 13:
                                O += "X";
                                break;
                            case 14:
                                O += "Y";
                                break;
                            case 15:
                                O += "Z";
                                break;
                            default:
                                break;
                        }
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
                switch ((CleanText[2 * T]).ToString())
                {
                    case "S": //S
                        CharNum = 16 * 0;
                        break;
                    case "6": //6
                        CharNum = 16 * 1;
                        break;
                    case "0": //0
                        CharNum = 16 * 2;
                        break;
                    case "2": //2
                        CharNum = 16 * 3;
                        break;
                    case "N": //N
                        CharNum = 16 * 4;
                        break;
                    case "T": //T
                        CharNum = 16 * 5;
                        break;
                    case "B": //B
                        CharNum = 16 * 6;
                        break;
                    case "4": //4
                        CharNum = 16 * 7;
                        break;
                    case "8": //8
                        CharNum = 16 * 8;
                        break;
                    case "E": //E
                        CharNum = 16 * 9;
                        break;
                    case "1"://1
                        CharNum = 16 * 10;
                        break;
                    case "G"://G
                        CharNum = 16 * 11;
                        break;
                    case "5"://5
                        CharNum = 16 * 12;
                        break;
                    case "3"://3
                        CharNum = 16 * 13;
                        break;
                    case "9"://9
                        CharNum = 16 * 14;
                        break;
                    case "7"://7
                        CharNum = 16 * 15;
                        break;
                    case "A"://A
                        CharNum = 16 * 16;
                        break;
                    default:
                        break;
                }
                switch ((CleanText[(2 * T) + 1]).ToString())
                {//     6	9	1	5	E	0	N	8	4	A	7	T	2	S	3	B	G
                    case "6": //S
                        CharNum += 0;
                        break;
                    case "9": //6
                        CharNum += 1;
                        break;
                    case "1": //0
                        CharNum += 2;
                        break;
                    case "5": //2
                        CharNum += 3;
                        break;
                    case "E": //N
                        CharNum += 4;
                        break;
                    case "0": //T
                        CharNum += 5;
                        break;
                    case "N": //B
                        CharNum += 6;
                        break;
                    case "8": //4
                        CharNum += 7;
                        break;
                    case "4": //8
                        CharNum += 8;
                        break;
                    case "A": //E
                        CharNum += 9;
                        break;
                    case "7"://1
                        CharNum += 10;
                        break;
                    case "T"://G
                        CharNum += 11;
                        break;
                    case "2"://5
                        CharNum += 12;
                        break;
                    case "S"://3
                        CharNum += 13;
                        break;
                    case "3"://9
                        CharNum += 14;
                        break;
                    case "B"://7
                        CharNum += 15;
                        break;
                    case "G"://A
                        CharNum += 16;
                        break;
                    default:
                        break;
                }
                MainText += ((char)(CharNum)).ToString();
            }
            return MainText;
        }

        #endregion
    }
}
