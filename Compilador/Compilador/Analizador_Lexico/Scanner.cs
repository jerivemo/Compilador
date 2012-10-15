/**
 * Scanner para la gram�tica de mini C# Compilador del curso de Compiladores e Int�rpretes.
 */
using System.Text;
using Runtime;

namespace Compilador.Analizador_Lexico
{
    class Scanner
    {
        private int comment_count = 0;
        private const int YY_BUFFER_SIZE = 512;
        private const int YY_F = -1;
        private const int YY_NO_STATE = -1;
        private const int YY_NOT_ACCEPT = 0;
        private const int YY_START = 1;
        private const int YY_END = 2;
        private const int YY_NO_ANCHOR = 4;
        private const int YY_BOL = 65536;
        private const int YY_EOF = 65537;

        public Symbol symbol(int type)
        {
            return new Symbol(type);
        }
        public Symbol symbol(int type, object value)
        {
            return new Symbol(type, value);
        }
        private System.IO.TextReader yy_reader;
        private int yy_buffer_index;
        private int yy_buffer_read;
        private int yy_buffer_start;
        private int yy_buffer_end;
        private char[] yy_buffer;
        private int yyline;
        private bool yy_at_bol;
        private int yy_lexical_state;

        public Scanner(System.IO.TextReader yy_reader1)
            : this()
        {
            if (null == yy_reader1)
            {
                throw (new System.Exception("Error: Bad input stream initializer."));
            }
            yy_reader = yy_reader1;
        }

        private Scanner()
        {
            yy_buffer = new char[YY_BUFFER_SIZE];
            yy_buffer_read = 0;
            yy_buffer_index = 0;
            yy_buffer_start = 0;
            yy_buffer_end = 0;
            yyline = 0;
            yy_at_bol = true;
            yy_lexical_state = YYINITIAL;
        }
        
     //   public Scanner(argv[] argv)
     //   {
     //       // TODO: Complete member initialization
     //       this.argv = argv;
    //    }

        private bool yy_eof_done = false;
        private const int COMMENT = 1;
        private const int YYINITIAL = 0;
        private static readonly int[] yy_state_dtrans = new int[] {
		0,
		48
	};
        private void yybegin(int state)
        {
            yy_lexical_state = state;
        }
        private int yy_advance()
        {
            int next_read;
            int i;
            int j;

            if (yy_buffer_index < yy_buffer_read)
            {
                return yy_buffer[yy_buffer_index++];
            }

            if (0 != yy_buffer_start)
            {
                i = yy_buffer_start;
                j = 0;
                while (i < yy_buffer_read)
                {
                    yy_buffer[j] = yy_buffer[i];
                    ++i;
                    ++j;
                }
                yy_buffer_end = yy_buffer_end - yy_buffer_start;
                yy_buffer_start = 0;
                yy_buffer_read = j;
                yy_buffer_index = j;
                next_read = yy_reader.Read(yy_buffer,
                        yy_buffer_read,
                        yy_buffer.Length - yy_buffer_read);
                if (next_read <= 0)
                {
                    return YY_EOF;
                }
                yy_buffer_read = yy_buffer_read + next_read;
            }

            while (yy_buffer_index >= yy_buffer_read)
            {
                if (yy_buffer_index >= yy_buffer.Length)
                {
                    yy_buffer = yy_double(yy_buffer);
                }
                next_read = yy_reader.Read(yy_buffer,
                        yy_buffer_read,
                        yy_buffer.Length - yy_buffer_read);
                if (next_read <= 0)
                {
                    return YY_EOF;
                }
                yy_buffer_read = yy_buffer_read + next_read;
            }
            return yy_buffer[yy_buffer_index++];
        }
        private void yy_move_end()
        {
            if (yy_buffer_end > yy_buffer_start &&
                '\n' == yy_buffer[yy_buffer_end - 1])
                yy_buffer_end--;
            if (yy_buffer_end > yy_buffer_start &&
                '\r' == yy_buffer[yy_buffer_end - 1])
                yy_buffer_end--;
        }
        private bool yy_last_was_cr = false;
        private void yy_mark_start()
        {
            int i;
            for (i = yy_buffer_start; i < yy_buffer_index; ++i)
            {
                if ('\n' == yy_buffer[i] && !yy_last_was_cr)
                {
                    ++yyline;
                }
                if ('\r' == yy_buffer[i])
                {
                    ++yyline;
                    yy_last_was_cr = true;
                }
                else yy_last_was_cr = false;
            }
            yy_buffer_start = yy_buffer_index;
        }
        private void yy_mark_end()
        {
            yy_buffer_end = yy_buffer_index;
        }
        private void yy_to_mark()
        {
            yy_buffer_index = yy_buffer_end;
            yy_at_bol = (yy_buffer_end > yy_buffer_start) &&
                        ('\r' == yy_buffer[yy_buffer_end - 1] ||
                         '\n' == yy_buffer[yy_buffer_end - 1] ||
                         2028/*LS*/ == yy_buffer[yy_buffer_end - 1] ||
                         2029/*PS*/ == yy_buffer[yy_buffer_end - 1]);
        }
        private string yytext()
        {
            return (new string(yy_buffer,
                yy_buffer_start,
                yy_buffer_end - yy_buffer_start));
        }
        private int yylength()
        {
            return yy_buffer_end - yy_buffer_start;
        }
        private char[] yy_double(char[] buf)
        {
            int i;
            char[] newbuf;
            newbuf = new char[2 * buf.Length];
            for (i = 0; i < buf.Length; ++i)
            {
                newbuf[i] = buf[i];
            }
            return newbuf;
        }
        private const int YY_E_INTERNAL = 0;
        private const int YY_E_MATCH = 1;
        private string[] yy_error_string = {
		"Error: Internal error.\n",
		"Error: Unmatched input.\n"
	};
        private void yy_error(int code, bool fatal)
        {
            System.Console.Write(yy_error_string[code]);
            System.Console.Out.Flush();
            if (fatal)
            {
                throw new System.Exception("Fatal Error.\n");
            }
        }
        private static int[][] unpackFromString(int size1, int size2, string st)
        {
            int colonIndex = -1;
            string lengthString;
            int sequenceLength = 0;
            int sequenceInteger = 0;

            int commaIndex;
            string workString;

            int[][] res = new int[size1][];
            for (int i = 0; i < size1; i++) res[i] = new int[size2];
            for (int i = 0; i < size1; i++)
            {
                for (int j = 0; j < size2; j++)
                {
                    if (sequenceLength != 0)
                    {
                        res[i][j] = sequenceInteger;
                        sequenceLength--;
                        continue;
                    }
                    commaIndex = st.IndexOf(',');
                    workString = (commaIndex == -1) ? st :
                        st.Substring(0, commaIndex);
                    st = st.Substring(commaIndex + 1);
                    colonIndex = workString.IndexOf(':');
                    if (colonIndex == -1)
                    {
                        res[i][j] = System.Int32.Parse(workString);
                        continue;
                    }
                    lengthString =
                        workString.Substring(colonIndex + 1);
                    sequenceLength = System.Int32.Parse(lengthString);
                    workString = workString.Substring(0, colonIndex);
                    sequenceInteger = System.Int32.Parse(workString);
                    res[i][j] = sequenceInteger;
                    sequenceLength--;
                }
            }
            return res;
        }
        private int[] yy_acpt = {
		/* 0 */ YY_NOT_ACCEPT,
		/* 1 */ YY_NO_ANCHOR,
		/* 2 */ YY_NO_ANCHOR,
		/* 3 */ YY_NO_ANCHOR,
		/* 4 */ YY_NO_ANCHOR,
		/* 5 */ YY_NO_ANCHOR,
		/* 6 */ YY_NO_ANCHOR,
		/* 7 */ YY_NO_ANCHOR,
		/* 8 */ YY_NO_ANCHOR,
		/* 9 */ YY_NO_ANCHOR,
		/* 10 */ YY_NO_ANCHOR,
		/* 11 */ YY_NO_ANCHOR,
		/* 12 */ YY_NO_ANCHOR,
		/* 13 */ YY_NO_ANCHOR,
		/* 14 */ YY_NO_ANCHOR,
		/* 15 */ YY_NO_ANCHOR,
		/* 16 */ YY_NO_ANCHOR,
		/* 17 */ YY_NO_ANCHOR,
		/* 18 */ YY_NO_ANCHOR,
		/* 19 */ YY_NO_ANCHOR,
		/* 20 */ YY_NO_ANCHOR,
		/* 21 */ YY_NO_ANCHOR,
		/* 22 */ YY_NO_ANCHOR,
		/* 23 */ YY_NO_ANCHOR,
		/* 24 */ YY_NO_ANCHOR,
		/* 25 */ YY_NO_ANCHOR,
		/* 26 */ YY_NO_ANCHOR,
		/* 27 */ YY_NO_ANCHOR,
		/* 28 */ YY_NO_ANCHOR,
		/* 29 */ YY_NO_ANCHOR,
		/* 30 */ YY_NO_ANCHOR,
		/* 31 */ YY_NO_ANCHOR,
		/* 32 */ YY_NO_ANCHOR,
		/* 33 */ YY_NO_ANCHOR,
		/* 34 */ YY_NO_ANCHOR,
		/* 35 */ YY_NO_ANCHOR,
		/* 36 */ YY_NO_ANCHOR,
		/* 37 */ YY_NO_ANCHOR,
		/* 38 */ YY_NO_ANCHOR,
		/* 39 */ YY_NO_ANCHOR,
		/* 40 */ YY_NO_ANCHOR,
		/* 41 */ YY_NO_ANCHOR,
		/* 42 */ YY_NO_ANCHOR,
		/* 43 */ YY_NO_ANCHOR,
		/* 44 */ YY_NO_ANCHOR,
		/* 45 */ YY_NO_ANCHOR,
		/* 46 */ YY_NO_ANCHOR,
		/* 47 */ YY_NO_ANCHOR,
		/* 48 */ YY_NO_ANCHOR,
		/* 49 */ YY_NO_ANCHOR,
		/* 50 */ YY_NO_ANCHOR,
		/* 51 */ YY_NOT_ACCEPT,
		/* 52 */ YY_NO_ANCHOR,
		/* 53 */ YY_NO_ANCHOR,
		/* 54 */ YY_NO_ANCHOR,
		/* 55 */ YY_NO_ANCHOR,
		/* 56 */ YY_NOT_ACCEPT,
		/* 57 */ YY_NO_ANCHOR,
		/* 58 */ YY_NOT_ACCEPT,
		/* 59 */ YY_NO_ANCHOR,
		/* 60 */ YY_NOT_ACCEPT,
		/* 61 */ YY_NOT_ACCEPT,
		/* 62 */ YY_NOT_ACCEPT,
		/* 63 */ YY_NOT_ACCEPT,
		/* 64 */ YY_NOT_ACCEPT,
		/* 65 */ YY_NOT_ACCEPT,
		/* 66 */ YY_NOT_ACCEPT,
		/* 67 */ YY_NOT_ACCEPT,
		/* 68 */ YY_NOT_ACCEPT,
		/* 69 */ YY_NOT_ACCEPT,
		/* 70 */ YY_NOT_ACCEPT,
		/* 71 */ YY_NOT_ACCEPT,
		/* 72 */ YY_NOT_ACCEPT,
		/* 73 */ YY_NOT_ACCEPT,
		/* 74 */ YY_NOT_ACCEPT,
		/* 75 */ YY_NOT_ACCEPT,
		/* 76 */ YY_NOT_ACCEPT,
		/* 77 */ YY_NOT_ACCEPT,
		/* 78 */ YY_NOT_ACCEPT,
		/* 79 */ YY_NOT_ACCEPT,
		/* 80 */ YY_NOT_ACCEPT,
		/* 81 */ YY_NOT_ACCEPT,
		/* 82 */ YY_NOT_ACCEPT,
		/* 83 */ YY_NOT_ACCEPT,
		/* 84 */ YY_NOT_ACCEPT,
		/* 85 */ YY_NOT_ACCEPT,
		/* 86 */ YY_NOT_ACCEPT,
		/* 87 */ YY_NOT_ACCEPT,
		/* 88 */ YY_NOT_ACCEPT,
		/* 89 */ YY_NOT_ACCEPT,
		/* 90 */ YY_NOT_ACCEPT,
		/* 91 */ YY_NOT_ACCEPT,
		/* 92 */ YY_NOT_ACCEPT,
		/* 93 */ YY_NOT_ACCEPT,
		/* 94 */ YY_NOT_ACCEPT,
		/* 95 */ YY_NOT_ACCEPT,
		/* 96 */ YY_NOT_ACCEPT,
		/* 97 */ YY_NOT_ACCEPT,
		/* 98 */ YY_NOT_ACCEPT,
		/* 99 */ YY_NOT_ACCEPT,
		/* 100 */ YY_NOT_ACCEPT,
		/* 101 */ YY_NOT_ACCEPT,
		/* 102 */ YY_NOT_ACCEPT,
		/* 103 */ YY_NOT_ACCEPT,
		/* 104 */ YY_NOT_ACCEPT,
		/* 105 */ YY_NOT_ACCEPT,
		/* 106 */ YY_NOT_ACCEPT,
		/* 107 */ YY_NOT_ACCEPT,
		/* 108 */ YY_NOT_ACCEPT,
		/* 109 */ YY_NOT_ACCEPT,
		/* 110 */ YY_NOT_ACCEPT,
		/* 111 */ YY_NOT_ACCEPT,
		/* 112 */ YY_NOT_ACCEPT,
		/* 113 */ YY_NOT_ACCEPT,
		/* 114 */ YY_NOT_ACCEPT,
		/* 115 */ YY_NOT_ACCEPT,
		/* 116 */ YY_NOT_ACCEPT,
		/* 117 */ YY_NOT_ACCEPT,
		/* 118 */ YY_NOT_ACCEPT,
		/* 119 */ YY_NOT_ACCEPT,
		/* 120 */ YY_NOT_ACCEPT,
		/* 121 */ YY_NOT_ACCEPT,
		/* 122 */ YY_NOT_ACCEPT,
		/* 123 */ YY_NOT_ACCEPT,
		/* 124 */ YY_NOT_ACCEPT,
		/* 125 */ YY_NOT_ACCEPT,
		/* 126 */ YY_NOT_ACCEPT,
		/* 127 */ YY_NOT_ACCEPT,
		/* 128 */ YY_NOT_ACCEPT,
		/* 129 */ YY_NOT_ACCEPT,
		/* 130 */ YY_NOT_ACCEPT,
		/* 131 */ YY_NOT_ACCEPT,
		/* 132 */ YY_NOT_ACCEPT,
		/* 133 */ YY_NOT_ACCEPT,
		/* 134 */ YY_NOT_ACCEPT,
		/* 135 */ YY_NOT_ACCEPT,
		/* 136 */ YY_NOT_ACCEPT,
		/* 137 */ YY_NOT_ACCEPT,
		/* 138 */ YY_NOT_ACCEPT,
		/* 139 */ YY_NOT_ACCEPT
	};
        private int[] yy_cmap = unpackFromString(1, 65538,
    "56:8,55:2,25,56,55,26,56:18,55,42,56:3,46,40,56,30,31,29,28,35,38,41,45,21," +
    "22:9,56,27,44,34,43,56:2,52,56,24,56,50,51,56:5,53,56:5,48,54,47,49,56:5,36" +
    ",56,37,56,20,56,3,14,1,17,13,9,19,12,8,56,15,2,56,6,5,23,56,10,4,7,16,18,11" +
    ",56:3,32,39,33,56:65410,0:2")[0];

        private int[] yy_rmap = unpackFromString(1, 140,
    "0,1:4,2,1:5,3,1:3,4,1,5,6,7,1:15,8,1:10,9,1,10,1:2,11,12,13,14,15,16,17,18," +
    "19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,8,40,41,42,4" +
    "3,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,6" +
    "8,69,70,71,72,73,74,55,75,76,77,78,79,80,81,82,83,84,85,86,87,88,89,90,91,9" +
    "2,93,94,95,96,97")[0];

        private int[][] yy_nxt = unpackFromString(98, 57,
    "1,51,56,-1:3,125,-1,58,60,132,61,-1,62,63,-1:2,64,126,-1:2,2,-1,127,-1,3,53" +
    ",4,5,6,7,8,9,10,11,12,13,14,15,65,66,16,67,17,18,19,20,68,-1:3,69,-1:3,21,-" +
    "1:86,24,-1:62,25,-1:60,26,-1:52,30,-1:56,31,-1:51,32,-1:15,80,-1:12,80:24,-" +
    "1,35,80:2,90,80:15,91,80:11,-1:2,109,-1:14,110,-1:2,46,-1:36,1,55:24,23,54," +
    "55:2,121,55:15,122,55:11,-1:2,70,-1:2,71,-1:72,52:2,-1:59,23,-1:32,55:24,23" +
    ",55:3,123,55:15,124,55:11,-1,55:24,-1,55:3,123,55:15,124,55:11,-1:13,72,-1:" +
    "44,55:24,-1,55:3,57,55:15,124,55:11,-1:9,22,-1:48,55:24,-1,55:3,123,55:15,5" +
    "9,55:11,-1:5,74,-1:61,128,-1,133,-1:46,76,-1:64,77,-1:54,78,-1:87,27,-1:57," +
    "28,-1:50,29,-1:70,81,-1:60,82,-1:7,130,-1:59,135,-1:57,129,-1:60,33,-1:55,3" +
    "4,-1:49,83,-1:3,84,-1:53,86,-1:65,87,-1:62,136,-1:45,88,-1:97,92,-1:60,93,-" +
    "1:20,36,-1:55,97,-1:42,99,-1:67,37,-1:46,100,-1:70,38,-1:45,137,-1:51,80:24" +
    ",-1,80:3,102,80:15,-1,80:11,-1,80:24,-1,80:3,-1,80:15,103,80:11,-1:50,39,-1" +
    ":60,104,-1:6,40,-1:59,41,-1:62,105,-1:53,106,-1:59,42,-1:56,43,-1:58,44,-1:" +
    "48,52,-1:50,80:24,-1,35,80:2,102,80:15,91,80:11,-1,80:24,-1,35,80:2,90,80:1" +
    "5,103,80:11,-1:50,45,-1:16,46,-1:52,47,-1:53,108,-1:67,111,-1:55,138,-1:51," +
    "112,-1:50,113,-1:73,114,-1:50,115,-1:51,117,-1:72,118,-1:39,46,-1:61,119,-1" +
    ":47,120,-1:63,3,-1:47,55:24,-1,55:3,57,55:15,49,55:11,-1,55:24,-1,55:3,50,5" +
    "5:15,59,55:11,-1,55:24,-1,55:3,57,55:15,-1,55:11,-1,55:24,-1,55:3,-1,55:15," +
    "59,55:11,-1:13,73,-1:48,79,-1:61,131,-1:54,134,-1:55,96,-1:53,94,-1:60,89,-" +
    "1:61,75,-1:51,85,-1:55,98,-1:53,95,-1:60,101,-1:55,107,-1:56,139,-1:56,116," +
    "-1:49");
      //  private argv[] argv;

        public Symbol nextToken()
        {
            int yy_lookahead;
            int yy_anchor = YY_NO_ANCHOR;
            int yy_state = yy_state_dtrans[yy_lexical_state];
            int yy_next_state = YY_NO_STATE;
            int yy_last_accept_state = YY_NO_STATE;
            bool yy_initial = true;
            int yy_this_accept;

            yy_mark_start();
            yy_this_accept = yy_acpt[yy_state];
            if (YY_NOT_ACCEPT != yy_this_accept)
            {
                yy_last_accept_state = yy_state;
                yy_mark_end();
            }
            while (true)
            {
                if (yy_initial && yy_at_bol) yy_lookahead = YY_BOL;
                else yy_lookahead = yy_advance();
                yy_next_state = YY_F;
                yy_next_state = yy_nxt[yy_rmap[yy_state]][yy_cmap[yy_lookahead]];
                if (YY_EOF == yy_lookahead && true == yy_initial)
                {

                    return new Symbol(sym.EOF);
                }
                if (YY_F != yy_next_state)
                {
                    yy_state = yy_next_state;
                    yy_initial = false;
                    yy_this_accept = yy_acpt[yy_state];
                    if (YY_NOT_ACCEPT != yy_this_accept)
                    {
                        yy_last_accept_state = yy_state;
                        yy_mark_end();
                    }
                }
                else
                {
                    if (YY_NO_STATE == yy_last_accept_state)
                    {
                        throw (new System.Exception("Lexical Error: Unmatched Input."));
                    }
                    else
                    {
                        yy_anchor = yy_acpt[yy_last_accept_state];
                        if (0 != (YY_END & yy_anchor))
                        {
                            yy_move_end();
                        }
                        yy_to_mark();
                        switch (yy_last_accept_state)
                        {
                            case 1:
                                break;
                            case -2:
                                break;
                            case 2:
                                { return symbol(sym.NUM, yytext()); }
                            case -3:
                                break;
                            case 3:
                                { return new Symbol(sym.CHARCONS, yytext()); }
                            case -4:
                                break;
                            case 4:
                                { return new Symbol(sym.PYCOMA); }
                            case -5:
                                break;
                            case 5:
                                { return new Symbol(sym.SUM); }
                            case -6:
                                break;
                            case 6:
                                { return new Symbol(sym.POR); }
                            case -7:
                                break;
                            case 7:
                                { return new Symbol(sym.P_ABI); }
                            case -8:
                                break;
                            case 8:
                                { return new Symbol(sym.P_CER); }
                            case -9:
                                break;
                            case 9:
                                { return new Symbol(sym.COR_A); }
                            case -10:
                                break;
                            case 10:
                                { return new Symbol(sym.COR_C); }
                            case -11:
                                break;
                            case 11:
                                { return new Symbol(sym.IGUAL); }
                            case -12:
                                break;
                            case 12:
                                { return new Symbol(sym.COMA); }
                            case -13:
                                break;
                            case 13:
                                { return new Symbol(sym.C_ABI); }
                            case -14:
                                break;
                            case 14:
                                { return new Symbol(sym.C_CER); }
                            case -15:
                                break;
                            case 15:
                                { return new Symbol(sym.RES); }
                            case -16:
                                break;
                            case 16:
                                { return new Symbol(sym.PUNTO); }
                            case -17:
                                break;
                            case 17:
                                { return new Symbol(sym.MAY); }
                            case -18:
                                break;
                            case 18:
                                { return new Symbol(sym.MEN); }
                            case -19:
                                break;
                            case 19:
                                { return new Symbol(sym.DIV); }
                            case -20:
                                break;
                            case 20:
                                { return new Symbol(sym.PORC); }
                            case -21:
                                break;
                            case 21:
                                break;
                            case -22:
                                break;
                            case 22:
                                { return new Symbol(sym.IF); }
                            case -23:
                                break;
                            case 23:
                                break;
                            case -24:
                                break;
                            case 24:
                                { return new Symbol(sym.SUM_SUM); }
                            case -25:
                                break;
                            case 25:
                                { return new Symbol(sym.IG_IG); }
                            case -26:
                                break;
                            case 26:
                                { return new Symbol(sym.IGU_IGU); }
                            case -27:
                                break;
                            case 27:
                                { return new Symbol(sym.O_O); }
                            case -28:
                                break;
                            case 28:
                                { return new Symbol(sym.Y_Y); }
                            case -29:
                                break;
                            case 29:
                                { return new Symbol(sym.DIF_IG); }
                            case -30:
                                break;
                            case 30:
                                { return new Symbol(sym.MAY_IG); }
                            case -31:
                                break;
                            case 31:
                                { return new Symbol(sym.MEN_IG); }
                            case -32:
                                break;
                            case 32:
                                { yybegin(COMMENT); comment_count = comment_count + 1; break; }
                            case -33:
                                break;
                            case 33:
                                { return new Symbol(sym.NEW); }
                            case -34:
                                break;
                            case 34:
                                { return new Symbol(sym.FOR); }
                            case -35:
                                break;
                            case 35:
                                break;
                            case -36:
                                break;
                            case 36:
                                { return new Symbol(sym.READ); }
                            case -37:
                                break;
                            case 37:
                                { return new Symbol(sym.ELSE); }
                            case -38:
                                break;
                            case 38:
                                { return new Symbol(sym.VOID); }
                            case -39:
                                break;
                            case 39:
                                { return new Symbol(sym.TRUE); }
                            case -40:
                                break;
                            case 40:
                                { return new Symbol(sym.CLASS); }
                            case -41:
                                break;
                            case 41:
                                { return new Symbol(sym.CONST); }
                            case -42:
                                break;
                            case 42:
                                { return new Symbol(sym.WRITE); }
                            case -43:
                                break;
                            case 43:
                                { return new Symbol(sym.WHILE); }
                            case -44:
                                break;
                            case 44:
                                { return new Symbol(sym.BREAK); }
                            case -45:
                                break;
                            case 45:
                                { return new Symbol(sym.FALSE); }
                            case -46:
                                break;
                            case 46:
                                { return symbol(sym.ID, yytext()); }
                            case -47:
                                break;
                            case 47:
                                { return new Symbol(sym.RETURN); }
                            case -48:
                                break;
                            case 48:
                                break;
                            case -49:
                                break;
                            case 49:
                                {
                                    comment_count = comment_count - 1;
                                    if (comment_count == 0)
                                    {
                                        yybegin(YYINITIAL);
                                    }
                                    else if (comment_count < 0)
                                    {
                                        throw (new System.Exception("Comentario anidado mal cerrado"));
                                    }
                                    break;
                                }
                            case -50:
                                break;
                            case 50:
                                { comment_count = comment_count + 1; break; }
                            case -51:
                                break;
                            case 52:
                                { return symbol(sym.NUM, yytext()); }
                            case -52:
                                break;
                            case 53:
                                { return new Symbol(sym.CHARCONS, yytext()); }
                            case -53:
                                break;
                            case 54:
                                break;
                            case -54:
                                break;
                            case 55:
                                break;
                            case -55:
                                break;
                            case 57:
                                break;
                            case -56:
                                break;
                            case 59:
                                break;
                            case -57:
                                break;
                            default:
                                yy_error(YY_E_INTERNAL, false); break;
                        }
                        yy_initial = true;
                        yy_state = yy_state_dtrans[yy_lexical_state];
                        yy_next_state = YY_NO_STATE;
                        yy_last_accept_state = YY_NO_STATE;
                        yy_mark_start();
                        yy_this_accept = yy_acpt[yy_state];
                        if (YY_NOT_ACCEPT != yy_this_accept)
                        {
                            yy_last_accept_state = yy_state;
                            yy_mark_end();
                        }
                    }
                }
            }
        }
    }
}