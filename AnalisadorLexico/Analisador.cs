using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalisadorLexico
{
    class Analisador
    {
        public List<string> listaLexema = new List<string>();

        public List<string> naoLexema = new List<string>();

        private int idOp = 0;

        private int status = 0;

        private bool flag = false;

        private bool flagDec = false;

        private int coluna = 0;

        private int fila = 1;

        private string textoConc = "";

        private string lexema = "";

        private char c;

        private bool isKeyWords(string token)
        {
            if (token.Length == 0)
                return false;
            var keyWords = new List<string>()
            {
                "algoritmo", "declare", "numerico", "literal", "se", "entao", "senao",
                "fimse", "leia", "escreva", "enquanto", "faca", "fimalgoritmo"
            };

            return keyWords.Exists(e => token == e);
        }

        private bool isOperator(string token)
        {
            if (!(token.Length > 0 || token.Length <= 2))
                return false;
            var operador = new List<string>()
            {
                "=", "+", "-", ">", "<", "==", "<=",
                ">=", ",", "*", "/", "%", "&&", "|", "=>"
            };

            return operador.Exists(e => token == e);
        }

        public string AnalisadorExec(string texto)
        {
            texto = texto + " ";
            for (int i = 0; i < texto.Length; i++)
            {
                c = texto[i];
                coluna++;

                switch (status)
                {
                    case 0:
                        if (char.IsLetter(c))
                        {
                            status = 1;
                            lexema += c;
                        }
                        else if (char.IsDigit(c))
                        {
                            status = 2;
                            lexema += c;
                        }
                        else if (c == '"')
                        {
                            status = 4;
                            i--;
                            coluna--;
                        }
                        else if (c == ' ')
                        {
                            status = 0;
                        }
                        else if (isOperator(c.ToString()))
                        {
                            status = 1;
                            lexema += c;
                            i--;
                            flag = true;
                        }
                        else if (c == '\n')
                        {
                            coluna = 0;
                            textoConc += '\n';
                            fila++;
                            status = 1;
                        }
                        else
                        {
                            status = -99;
                            i--;
                            coluna--;
                        }
                        break;
                    case 1:
                        if (char.IsLetterOrDigit(c) || c == '_')
                        {
                            lexema += c;
                            status = 1;
                        }
                        else
                        {
                            string identificador = null;

                            if (lexema == "declare")
                                flagDec = true;

                            if (lexema == "numerico" || lexema == "literal")
                                flagDec = false;

                            identificador = buscarToken(lexema);
                            if (identificador != null)
                            {
                                textoConc += identificador;

                                if (flag)
                                {
                                    i++;
                                    flag = false;
                                }
                            }
                            lexema = "";
                            i--;
                            coluna--;
                            status = 0;
                        }
                        break;
                    case 2:
                        if (char.IsDigit(c))
                        {
                            lexema += c;
                            status = 2;
                        }
                        else if (c == '.')
                        {
                            status = 8;
                            lexema += c;
                        }
                        else if (c == ' ')
                        {
                            status = 1;
                            i--;
                        }
                        else if (isOperator(c.ToString()))
                        {
                            status = 1;
                            i--;
                        }
                        else if (c == '\n')
                        {
                            coluna = 0;
                            fila++;
                            status = 1;
                            i--;
                        }
                        else
                        {
                            lexema = "";
                            i--;
                            coluna--;
                            status = 0;
                        }
                        break;
                    case 3:
                        if (char.IsDigit(c))
                        {
                            lexema += c;
                            status = 2;
                        }
                        else
                        {
                            status = -99;
                            i = i - 2;
                            coluna = coluna - 2;
                            lexema = "";
                        }
                        break;
                    case 4:
                        if (c == '"')
                        {
                            lexema += c;
                            status = 5;
                        }
                        break;
                    case 5:
                        if (c != '"')
                        {
                            lexema += c;
                            status = 5;
                        }
                        else
                        {
                            lexema += c;
                            status = 1;
                            i--;
                            coluna--;
                        }
                        break;
                    case 6:
                        if (c == '"')
                        {
                            lexema += c;
                            status = 0;
                            lexema = "";
                        }
                        break;

                    case 8:
                        {
                            if (char.IsDigit(c))
                            {
                                status = 9;
                                lexema += c;
                            }
                            else
                            {
                                status = 0;
                                lexema = "";
                            }
                            break;
                        }

                    case 9:
                        {
                            if (char.IsDigit(c))
                            {
                                status = 9;
                                lexema += c;
                            }
                            else
                            {
                                lexema = "";
                                i--;
                                coluna--;
                                status = 0;
                            }
                            break;
                        }

                    case -99:
                        {
                            lexema += c;
                            status = 0;
                            lexema = "";
                            break;
                        }
                }
            }
            return textoConc;
        }

        public string buscarToken(string lexema)
        {
            if (isKeyWords(lexema))
            {
                return $"<{lexema}>";
            }
            else if (isOperator(lexema))
                return $"<op, {lexema}>";
            else if (lexema.Where(c => char.IsDigit(c)).Count() > 0)
            {
                return $"<num, {lexema}>";
            }
            else if (lexema.Length > 0 && !lexema.Contains('"'))
            {
                if (listaLexema.Exists(e => lexema == e))
                {
                    var lex = listaLexema.FindIndex(e => lexema == e);
                    return $"<id, {lex + 1}>";
                }
                else if (!flagDec)
                {
                    naoLexema.Add(lexema);
                    return lexema;
                }
                else
                {
                    listaLexema.Add(lexema);
                    idOp += 1;
                    return $"<id, {idOp}>";
                }
            }
            else if (lexema.Contains('"'))
            {
                flag = true;
                return $@"<literal, {lexema}>";
            }

            return null;
        }
    }
}
