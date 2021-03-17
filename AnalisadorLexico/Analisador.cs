using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalisadorLexico
{
    class Analisador
    {
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
            if (token.Length == 0 || token.Length > 1)
                return false;
            var operador = new List<string>()
            {
                "=", "+", "-", ">", "<", "==", "<=",
                ">=", ",", "*", "/", "%", "&&", "||"
            };

            return operador.Exists(e => token == e);
        }

        public string AnalisadorExec(string texto)
        {
            var listaLexema = new List<string>();

            int status = 0;

            int coluna = 0;

            int idOp = 0;

            int fila = 1;

            string textoConc = "";

            string lexema = "";
            char c;

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
                        else if (c == ',')
                        {
                            status = 6;
                            i--;
                            coluna--;
                        }
                        else if (c == ' ')
                        {
                            status = 0;
                        }
                        else if (c == '\n')
                        {
                            coluna = 0;
                            textoConc += '\n'; 
                            fila++;
                            status = 0;
                        }
                        else if (c == '{')
                        {
                            lexema += c;
                            lexema = "";
                        }
                        else if (c == '}')
                        {
                            lexema += c;
                            lexema = "";
                        }
                        else if (c == '(')
                        {
                            lexema += c;
                            lexema = "";
                        }
                        else if (c == ')')
                        {
                            lexema += c;
                            lexema = "";
                        }
                        else if (c == ',')
                        {
                            lexema += c;
                            lexema = "";
                        }

                        else if (c == ';')
                        {
                            lexema += c;
                            lexema = "";
                        }

                        else if (c == '<')
                        {
                            lexema += c;
                            lexema = "";
                        }
                        else if (c == '>')
                        {
                            lexema += c;
                            lexema = "";
                        }

                        else if (c == '.')
                        {
                            lexema += c;
                            lexema = "";
                        }
                        else if (c == '+')
                        {
                            lexema += c;
                            lexema = "";
                        }
                        else if (c == '-')
                        {
                            lexema += c;
                            lexema = "";
                        }
                        else if (c == '*')
                        {
                            lexema += c;
                            lexema = "";
                        }
                        else if (c == '/')
                        {
                            lexema += c;
                            lexema = "";
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
                            bool identificador = false;
                            /*Usar essa função para separar as tabelas*/
                            identificador = buscarToken(lexema);
                            if (identificador)
                            {
                                textoConc += "<" + lexema + ">";
                            }
                            else
                            {
                                //Tabela Token
                                listaLexema.Add(lexema);
                                idOp += 1;
                                textoConc += $"<id,{idOp}>"; 
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
                            status = 6;
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
                        else if (c == ',')
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

        public bool buscarToken(string lexema)
        {
            if (isKeyWords(lexema))
                return true;
            if (isOperator(lexema))
                return true;

            return false;
        }
    }
}
