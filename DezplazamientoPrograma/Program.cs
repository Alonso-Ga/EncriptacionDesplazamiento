using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DezplazamientoPrograma
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] abecedario = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            Console.WriteLine("DESPLAZAMIENTO\n ¿QUE DESEA HACER?\n (1) ENCRIPTAR (2) DESENCRIPTAR");
            string opcion = Console.ReadLine();
            if (opcion == "1")
            {
                //Mensaje en claro ingresa
                Console.WriteLine("Ingrese el Mensaje en claro: ");
                string mensajeclaro = Console.ReadLine();
                mensajeclaro = mensajeclaro.Replace(" ", string.Empty);
                mensajeclaro = mensajeclaro.ToLower();
                //llave
                Console.WriteLine("Ingrese llave(SOLO UNA LETRA): ");
                string llave = Console.ReadLine();
                llave = llave.ToLower();

                int[] mclnumerico = new int[mensajeclaro.Length];
                //mensaje en un arreglo
                char[] arreglomensaje;
                arreglomensaje = mensajeclaro.ToCharArray(0, mensajeclaro.Length);

                //recorrer abecedario y arreglomensaje para asignar valor

                for (int a = 0; a < arreglomensaje.Length; a++)
                {
                    for (int i = 0; i < abecedario.Length; i++)
                    {
                        string varmens = arreglomensaje[a].ToString();
                        string varabc = abecedario[i].ToString();
                        if (varmens == varabc)
                        {
                            mclnumerico[a] = i;

                        }
                    }
                }
                //LLAVE A VALOR NUMERICO
                int k = 0;

                for (int i = 0; i < abecedario.Length; i++)
                {
                    string aux = abecedario[i].ToString();
                    if (aux == llave)
                    {
                        k = i;
                    }
                }
                //SUMA
                int[] llavenumerico = new int[mensajeclaro.Length];

                for (int i = 0; i < mclnumerico.Length; i++)
                {
                    llavenumerico[i] = mclnumerico[i] + k;
                }

                //MOD26
                int[] mod26 = new int[llavenumerico.Length];
                for (int i = 0; i < llavenumerico.Length; i++)
                {

                    mod26[i] = llavenumerico[i] % 26;
                }
                //VALOR NUMERICO A ABECEDARIO
                string resultado = "";
                for (int i = 0; i < mod26.Length; i++)
                {
                    for (int a = 0; a < abecedario.Length; a++)
                    {
                        int aux = a;
                        if (mod26[i] == aux)
                        {
                            resultado = resultado + abecedario[a].ToString();
                        }
                    }
                }
                //COMPROBACIONES

                Console.WriteLine("VALOR NUMERICO A ABECEDARIO " + resultado.ToUpper());
                Console.ReadKey();


            }
            if(opcion =="2")
            {
                //Mensaje en claro ingresa
                Console.WriteLine("Ingrese el Mensaje en claro: ");
                string mensajeclaro = Console.ReadLine();
                mensajeclaro = mensajeclaro.Replace(" ", string.Empty);
                mensajeclaro = mensajeclaro.ToLower();
                //llave
                Console.WriteLine("Ingrese llave(SOLO UNA LETRA): ");
                string llave = Console.ReadLine();
                llave = llave.ToLower();

                int[] mclnumerico = new int[mensajeclaro.Length];
                //mensaje en un arreglo
                char[] arreglomensaje;
                arreglomensaje = mensajeclaro.ToCharArray(0, mensajeclaro.Length);

                //recorrer abecedario y arreglomensaje para asignar valor

                for (int a = 0; a < arreglomensaje.Length; a++)
                {
                    for (int i = 0; i < abecedario.Length; i++)
                    {
                        string varmens = arreglomensaje[a].ToString();
                        string varabc = abecedario[i].ToString();
                        if (varmens == varabc)
                        {
                            mclnumerico[a] = i;

                        }
                    }
                }
                //LLAVE A VALOR NUMERICO
                int k = 0;

                for (int i = 0; i < abecedario.Length; i++)
                {
                    string aux = abecedario[i].ToString();
                    if (aux == llave)
                    {
                        k = i;
                    }
                }
                //RESTA
                double[] llavenumerico = new double[mensajeclaro.Length];

                for (int i = 0; i < mclnumerico.Length; i++)
                {
                    llavenumerico[i] = mclnumerico[i] - k;
                }

                //MOD26
                double[] mod26 = new double[llavenumerico.Length];
                for (int i = 0; i < llavenumerico.Length; i++)
                {
                    if (llavenumerico[i] <= -1)
                    {
                        mod26[i] = llavenumerico[i] + 26;
                    }
                    else
                    {
                        mod26[i] = llavenumerico[i] % 26;
                    }
                }
                //VALOR NUMERICO A ABECEDARIO
                string resultado = "";
                for (int i = 0; i < mod26.Length; i++)
                {
                    for (int a = 0; a < abecedario.Length; a++)
                    {
                        double aux = a;
                        if (mod26[i] == aux)
                        {
                            resultado = resultado + abecedario[a].ToString();
                        }
                    }
                }
                Console.WriteLine("VALOR NUMERICO A ABECEDARIO " + resultado.ToUpper());
                Console.ReadKey();

                Console.ReadKey();
            }
        }
    }
}
