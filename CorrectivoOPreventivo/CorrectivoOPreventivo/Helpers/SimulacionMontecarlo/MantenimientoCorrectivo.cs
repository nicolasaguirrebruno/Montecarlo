using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CorrectivoOPreventivo.Helpers.SimulacionMontecarlo
{
    internal class MantenimientoCorrectivo
    {

        public int CalcularDiaArreglo(double rnd) {
        
            for (int i = 0; i < Program.probabilidades.Length; i++) {

                if (rnd <= Program.probabilidades[i]) {

                    return i + 4;
                }

               
            }
            return -1;
        }

        public void EstablecerFilaDataGridView(DataGridView correctivo, (int, double,int, int, string,int,double,double) fila) {
         
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

            correctivo.Rows.Add(row);
        }

        private bool EstaDentroIntervalo(int i, double desde, double hasta, (int, double, int, int, string, int, double, double) fila, DataGridView correctivo) {
            if (i >= desde && i <= hasta)
            {
                EstablecerFilaDataGridView(correctivo,fila);
            }

            return false;
        }
      

        public void CalcularCorrectivo(double cant, double desde, double hasta, DataGridView correctivo) {
            Random rand = new Random();


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

                    if (i != filaAnterior.Item4)
                    {
                        if (filaAnterior.Item5 == "Si")
                        {
                            var rndAveria = rand.NextDouble();

                            int diaArreglo = CalcularDiaArreglo(rndAveria);

                            filaActual = (i, rndAveria, diaArreglo, i + diaArreglo, "No", filaAnterior.Item6, 0.0, filaAnterior.Item8);

                            EstaDentroIntervalo(i, desde, hasta, filaActual, correctivo);


                            filaAnterior = filaActual;

                        }
                        else {

                            filaActual = (i, 0.0, filaAnterior.Item3 - 1, filaAnterior.Item4, filaAnterior.Item5, filaAnterior.Item6, filaAnterior.Item7, filaAnterior.Item8);
                            EstaDentroIntervalo(i, desde, hasta, filaActual, correctivo);

                            filaAnterior = filaActual;
                        }

                      

                    }
                    else
                    {


                        
                       filaActual = (i, 0.0, filaAnterior.Item3-1, filaAnterior.Item4, "Si", i, 1100, filaAnterior.Item8 + 1100);

                        EstaDentroIntervalo(i, desde, hasta, filaActual, correctivo);

                        filaAnterior = filaActual;

                        /// suponiendo que es el día de correctivo
                        Program.DiasPerdidosCorrectivoMC += 1;
                      
                    }


                    if (i == cant && i > hasta) {
                        EstablecerFilaDataGridView(correctivo, filaActual);
                        Program.acumCorrectivo = filaActual.Item8;
                    } 

                   
                }

                
                

            }

            
        }
    }
}
