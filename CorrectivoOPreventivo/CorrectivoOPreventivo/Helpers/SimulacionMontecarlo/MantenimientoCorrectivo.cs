using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CorrectivoOPreventivo.Helpers.SimulacionMontecarlo
{
    internal class MantenimientoCorrectivo
    {

        public int CalcularDiaArreglo(double rnd) 
        {
            // Recorre el arreglo de las probabilidades acumuladas
            for (int i = 0; i < Program.probabilidades.Length; i++) 
            {
                // Hace lo que dijo carena de que si es menor
                // que la probabilidad significa que esta en ese
                // intervalo
                if (rnd <= Program.probabilidades[i]) 
                {

                    // Suponete que son 4 dias,
                    // entonces la vuelta seria la primera con i valor 0,
                    // entonces le sumo cuatro, si fuesen cinco dias seria
                    // segunda vuelta con i valor 1 y
                    // le sumo 4 para tener 5 dias y asi.
                    return i + 4;
                }

               
            }
            return -1;
        }
        ///<summary>
        ///transforma la tupla de la fila en un arreglo de string y la agrega al datagridview
        ///</summary>
        public void EstablecerFilaDataGridView(DataGridView correctivo, (int, double,int, int, string,int,double,double) fila) {

            // Paso a string todo para ponerlo
            // en la tabla porque nomas acepta strings
            String[] row = {
                fila.Item1.ToString(),
                  fila.Item2.ToString(),
                      fila.Item3.ToString(),
                          fila.Item4.ToString(),
                              fila.Item5.ToString(),
                                  fila.Item6.ToString(),
                                    fila.Item7.ToString(),
                                          fila.Item8.ToString(),
                };
            // Poner en la tabla
            correctivo.Rows.Add(row);
        }
        /// <summary>
        /// Nos dice si el dia simulado esta dentro del intervalo que se deve mostrar
        /// y lo agrega a la tabla
        /// </summary>
        
        private void EstaDentroIntervalo(int i, double desde, double hasta, (int, double, int, int, string, int, double, double) fila, DataGridView correctivo) {
            if (i >= desde && i <= hasta)
            {
                //Metodo para poner los datos en la tabla
                EstablecerFilaDataGridView(correctivo,fila);
            }

        }

        /// <summary>
        /// Metodo que se encarga de hacer la simulacion de montecarlo Para el mantenimiento correctivo
        /// grabando en el datagridview el intervalo solicitado
        /// </summary>
        public void CalcularCorrectivo(double cant, double desde, double hasta, DataGridView correctivo) 
        {
            Random rand = new Random();
            //usamos 2 filas para el calculo, sus valores iniciales van a ser 0
            // (Día, RND averia, Dias para el reparo, Dias a reparar, se reparó?, último día arreglado, costo, costo acumulado 
            var filaAnterior = (0, 0.0, 0, 0, "",0, 0.0, 0.0);
            var filaActual = (0, 0.0,0, 0, "",0, 0.0, 0.0);


            for (int i = 1; i <= cant; i++)
            {
               
                if (i == 1)
                {
                    var rndAveria = rand.NextDouble();

                    int diaArreglo = CalcularDiaArreglo(rndAveria);

                    filaActual = (i, rndAveria, diaArreglo, i + diaArreglo, "No", 0, 0.0, 0.0);

                    EstaDentroIntervalo(i, desde, hasta, filaActual, correctivo);
                    


                    filaAnterior = filaActual;
                }
                else {
                    //evaluamos que el dia actual sea distinto al dia del arreglo
                    if (i != filaAnterior.Item4)
                    {
                        // se reparo el dia anterior?
                        
                        if (filaAnterior.Item5 == "Si")
                        {
                            // si se reparo entonces calculamos cuando se va a romper de nuevo
                            var rndAveria = rand.NextDouble();

                            int diaArreglo = CalcularDiaArreglo(rndAveria);
                            //cargamos la fila actual
                           
                            filaActual = (i, rndAveria, diaArreglo, i + diaArreglo, "No", filaAnterior.Item6, 0.0, filaAnterior.Item8);
                            
                            //si esta dentro del intervalo lo cargamos en la tabla 
                            EstaDentroIntervalo(i, desde, hasta, filaActual, correctivo);

                            // esta fila ahora es la anterior
                            filaAnterior = filaActual;

                        }
                        else {
                            //si no se reparo
                            //cargamos la fila actual
                            // El random vale 0.0 porque a menos que sea la iteracion siguiente al arreglo no se vuelve a sacar uno.
                            // El item 3 se resta porque ambos represenan los dias que faltan para el arreglo.
                            // El resto de items se mantienen tal cual
                            filaActual = (i, 0.0, filaAnterior.Item3 - 1, filaAnterior.Item4, filaAnterior.Item5, filaAnterior.Item6, filaAnterior.Item7, filaAnterior.Item8);
                            //si esta en el intervalo a mostrar, la mostramos
                            EstaDentroIntervalo(i, desde, hasta, filaActual, correctivo);
                            //esta fila ahora es la anterior
                            filaAnterior = filaActual;
                        }
                    }
                    else
                    {
                        // el dia actual es igual al dia del arreglo entonces efectuamos los calculos en esta rama
                        //cargamos la fila actual
                        // En la columna del "Se reparo" se cambia por Si indicando que se efectuo el arrelgo,
                        // se setea el valor del arreglo (1100) y se lo suma al valor que viene arrastrando en el acummulado. Resto de filas igual

                        filaActual = (i, 0.0, filaAnterior.Item3-1, filaAnterior.Item4, "Si", i, 1100, filaAnterior.Item8 + 1100);
                        // Comprueba si esta dentro del intervalo solicitado el usuario para mostrarlo en la 
                        EstaDentroIntervalo(i, desde, hasta, filaActual, correctivo);

                        filaAnterior = filaActual;

                        // se perdio un dia por mantenimiento
                        Program.DiasPerdidosCorrectivoMC += 1;
                      
                    }

                    // Si el dia es el ultimo
                    if (i == cant ) {
                        // si no se mostro el ultimo dia en la tabla ya
                        if (i > hasta)
                        {
                            EstablecerFilaDataGridView(correctivo, filaActual);
                        }
                        // seteamos el acumulador Correctivo
                        Program.acumCorrectivo = filaActual.Item8;
                    } 

                   
                }

                
                

            }

            
        }
    }
}
