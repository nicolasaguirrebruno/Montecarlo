using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectivoOPreventivo.Helpers.SimulacionMontecarlo
{
    internal class MantenimientoPreventivo
    {

      

        public int CalcularDiaArreglo(double rnd)
        {
            // Recorre el arreglo de las probabilidades acumuladas
            for (int i = 0; i < Program.probabilidades.Length; i++)
            {
                // Hace lo que dijo carena de que si es menor que la probabilidad significa que esta en ese intervalo
                if (rnd <= Program.probabilidades[i])
                {
                    Console.Write(i.ToString());
                   
                    // Suponete que son 4 dias, entonces la vuelta seria la primera con i valor 0, entonces le sumo cuatro, si fuesen cinco dias seria segunda vuelta con i valor 1 y le sumo 4 para tener 5 dias y asi.
                    return i + 4;
                }


            }
            return -1;
        }



        private bool EstaDentroIntervalo(int i, double desde, double hasta, (int, double, int, int, int, int, string, string, double, int, int, double, double)  fila, DataGridView preventivo)
        {
            if (i >= desde && i <= hasta)
            {
                //Metodo para poner los datos en la tabla
                EstablecerFilaDataGridView(preventivo, fila);
            }

            return false;
        }



        public void EstablecerFilaDataGridView(DataGridView preventivo, (int, double, int, int, int,int, string, string, double,int, int, double, double) fila)
        {
            // Paso a string todo para ponerlo en la tabla porque nomas acepta strings
            String[] row = {
                fila.Item1.ToString(),
                  fila.Item2.ToString(),
                      fila.Item3.ToString(),
                          fila.Item4.ToString(),
                              fila.Item5.ToString(),
                                  fila.Item6.ToString(),
                                    fila.Item7.ToString(),
                                          fila.Item8.ToString(),
                                            fila.Item9.ToString(),
                                                fila.Item10.ToString(),
                                                    fila.Item11.ToString(),
                                                        fila.Item12.ToString(),
                                                            fila.Item13.ToString(),
                };

            // Poner en la tabla
            preventivo.Rows.Add(row);
        }


        private  (int, double, int, int, int, int, string, string, double, int, int, double, double)  SimularReparacion(Random rand, double desde, double hasta, int i, (int, double, int, int, int, int, string, string, double, int, int, double, double) filaActual, (int, double, int, int, int, int, string, string, double, int, int, double, double) filaAnterior, DataGridView preventivo)
        {
            //Esto evalua que el dia actual sea distinto al dia del arreglo
            if (i != filaAnterior.Item4)
            {
                // Primero leer los dos else a continuacion para que sea mas facil de leer esto. Ahora que ya leiste, esto representa la primera iteracion despues del arreglo, por lo tanto la fila del Se Reparo tiene un si
                // Este condicional se usa para hacer algo similar a lo que se hace en el dia 1, es decir, volver a tirar un random, setearlo y demas.
                if (filaAnterior.Item7 == "Si")
                {
                    var rndAveria = rand.NextDouble();

                    int diaArreglo = CalcularDiaArreglo(rndAveria);

                    // El siguiente mantenimiento sera de aca a 5 dias de trabajo
                    int diaMantenimiento = 5 + i;

                    // Idem que cuando es el primer dia de trabajo
                    filaActual = (i, rndAveria, diaArreglo, i + diaArreglo, diaMantenimiento - 1, diaMantenimiento, "No", "No", filaAnterior.Item9, filaAnterior.Item10, 0, filaAnterior.Item12, filaAnterior.Item13);

                    // Comprueba si esta dentro del intervalo solicitado el usuario para mostrarlo en la tabla
                    EstaDentroIntervalo(i, desde, hasta, filaActual, preventivo);



                }
                // Se establece la fila actual para el dia especifico
                else
                {
                    // El random vale 0.0 porque a menos que sea la iteracion siguiente al arreglo no se vuelve a sacar uno. El item 3 y 5 se restan porque ambos represenan los dias que faltan para el arreglo o mantenimiento. El resto de items se mantienen tal cual
                    filaActual = (i, 0.0, filaAnterior.Item3 - 1, filaAnterior.Item4, filaAnterior.Item5 - 1, filaAnterior.Item6, filaAnterior.Item7, filaAnterior.Item8, filaAnterior.Item9, filaAnterior.Item10, 0, filaAnterior.Item12, filaAnterior.Item13);

                    // Comprueba si esta dentro del intervalo solicitado el usuario para mostrarlo en la tabla
                    EstaDentroIntervalo(i, desde, hasta, filaActual, preventivo);

                  
                }





            }
            // Si el dia actual es igual al dia del arreglo entonces efectuamos los calculos en esta rama
            else
            {
                // En la columna del "Se reparo" se cambia por Si indicando que se efectuo el arrelgo, se setea el valor del arreglo (1100) y se lo suma al valor que viene arrastrando en el acummulado. Resto de filas igual
                filaActual = (i, 0.0, filaAnterior.Item3 - 1, filaAnterior.Item4, filaAnterior.Item5 - 1, filaAnterior.Item6, "Si", "No", i, filaAnterior.Item10, 1100, filaAnterior.Item12, (filaAnterior.Item13 + 1100));



                // Comprueba si esta dentro del intervalo solicitado el usuario para mostrarlo en la tabla
                EstaDentroIntervalo(i, desde, hasta, filaActual, preventivo);


                // considerando que sea un día de arreglo, sumo uno al día perdido 
                Program.DiasPerdidosCorrectivoMP += 1; 

            }
            // retorno la fila actual porque sino nunca se va a actualizar en el metodo general de esta clase, lo que llevaria a un error.
            return filaActual;
        }



        private (int, double, int, int, int, int, string, string, double, int, int, double, double) SimularMantenimiento(Random rand, double desde, double hasta, int i, (int, double, int, int, int, int, string, string, double, int, int, double, double) filaActual, (int, double, int, int, int, int, string, string, double, int, int, double, double) filaAnterior, DataGridView preventivo) {

            //Esto evalua que el dia actual sea distinto al dia del mantenimiento
            if (i != filaAnterior.Item6)
            {

                // Primero leer los dos else a continuacion para que sea mas facil de leer esto. Ahora que ya leiste, esto representa la primera iteracion despues del mantenimiento, por lo tanto la fila del Se Mantuvo tiene un si
                // Este condicional se usa para hacer algo similar a lo que se hace en el dia 1, es decir, volver a tirar un random, setearlo y demas.
                if (filaAnterior.Item8 == "Si")
                {
                    var rndAveria = rand.NextDouble();

                    int diaArreglo = CalcularDiaArreglo(rndAveria);

                    // El siguiente mantenimiento sera de aca a 5 dias de trabajo
                    int diaMantenimiento = i + 5;

                    // Idem que cuando es el primer dia de trabajo
                    filaActual = (i, rndAveria, diaArreglo, i + diaArreglo, 5, diaMantenimiento, "No", "No", filaAnterior.Item9, filaAnterior.Item10, filaAnterior.Item11, 0, filaAnterior.Item13);


                    // Comprueba si esta dentro del intervalo solicitado el usuario para mostrarlo en la tabla
                    EstaDentroIntervalo(i, desde, hasta, filaActual, preventivo);


                    // Setea la fila anterior como la actual, explicado en el metodo principal a detalle.
                    filaAnterior = filaActual;





                }
                // Se establece la fila actual para el dia especifico
                else
                {
                    // El random vale 0.0 porque a menos que sea la iteracion siguiente al mantenimiento no se vuelve a sacar uno. El item 3 y 5 se restan porque ambos represenan los dias que faltan para el arreglo o mantenimiento. El resto de items se mantienen tal cual

                    filaActual = (i, 0.0, filaAnterior.Item3 - 1, filaAnterior.Item4, filaAnterior.Item5 - 1, filaAnterior.Item6, filaAnterior.Item7, filaAnterior.Item8, filaAnterior.Item9, filaAnterior.Item10, 0, filaAnterior.Item12, filaAnterior.Item13);


                    // Comprueba si esta dentro del intervalo solicitado el usuario para mostrarlo en la tabla
                    EstaDentroIntervalo(i, desde, hasta, filaActual, preventivo);



                }

             // Si el dia actual es igual al dia del mantenimiento entonces efectuamos los calculos en esta rama

            }
            else
            {

                // En la columna del "Se mantuvo" se cambia por Si indicando que se efectuo el arrelgo, se setea el valor del mantenimiento(600) y se lo suma al valor que viene arrastrando en el acummulado. Resto de filas igual

                filaActual = (i, 0.0, filaAnterior.Item3 - 1, filaAnterior.Item4, filaAnterior.Item5 - 1, filaAnterior.Item6, "No", "Si", filaAnterior.Item9, i, filaAnterior.Item11, 600, (filaAnterior.Item13 + 600));

                // Comprueba si esta dentro del intervalo solicitado el usuario para mostrarlo en la tabla
                EstaDentroIntervalo(i, desde, hasta, filaActual, preventivo);

                // considerando que el día es el de mantenimiento, aumento uno el contador de días mantenidos 

                Program.DiasPerdidosMantenimiento += 1; 

            }
            // retorno la fila actual porque sino nunca se va a actualizar en el metodo general de esta clase, lo que llevaria a un error.

            return filaActual;
        }




            public void CalcularPreventivo(double cant, double desde, double hasta, DataGridView preventivo)
        {
            Random rand = new Random();


            // Dia | RND Averia | Dias para el Reparo| Dia a Reparar | Dias para el mantenimiento | Dia de mantenimiento |	Se reparo?| 	Se mantuvo? |	Ultimo Dia Arreglado | Ultimo Dia Mantenido | Costo Reparacion | 	Costo Mantenimiento |	Costo Acumulado

            var filaAnterior = (0, 0.0, 0, 0, 0, 0, "No", "No", 0.0, 0, 0, 0.0, 0.0);
            var filaActual = (0, 0.0, 0, 0, 0, 0, "No", "No", 0.0, 0, 0, 0.0, 0.0);



            for (int i = 1; i <= cant; i++)
            {
                // Miro la primera vuelta para setear los valores inicales
                if (i == 1)
                {
                    var rndAveria = rand.NextDouble();

                    //Se calcula el diaArreglo que es el numero de dias despues de la ultima revision o arreglo donde indica la probabilidad que se va a romper
                    int diaArreglo = CalcularDiaArreglo(rndAveria);

                    // Como es la primera vuelta se puede hardcodear el dia de mantenimiento que por enunciado sabemos que sera el dia 5
                    int diaMantenimiento = 5;

                    // Seteamos los valores de la primera iteracion donde el dia de arreglo sera igual a la suma del dia actual mas los dias que faltan para que se rompa (especificado por carena)
                    // Se setea diaMantenimiento - 1 puesto que ya con este dia de trabajo faltan solo 4 para llegar al dia 5 que es donde al final del mismo se hara el mantenimiento
                    // diaMantenimiento sirve al usuario para saber que dia numerico sera el mantenimiento, para esta primera vuelta sera 5 porque recien arranca el programa y el problema dice que supone un motor nuevo en el dia 1
                    filaActual = (i, rndAveria, diaArreglo, i + diaArreglo, diaMantenimiento - 1, diaMantenimiento, "No", "No", 0.0, 0, 0, 0.0, 0.0);

                   
                    //Este metodo lo que hace es mirar si el dia actual esta comprendido en el intervalo que mando el usuario, de ser asi lo pone en la grilla (NO LO GUARDA, no usamos matrices, solo dos filas como dice el enunciado)
                    EstaDentroIntervalo(i,desde,hasta,filaActual, preventivo);

                    // seteo la fila anterior como la actual, para a partir de ella obtener los datos necesarios en la siguiente iteracion, ademas de que en el medio de la fila actual y la anterior deberan incluir los calculos de las 4 metricas que hay que definir
                    filaAnterior = filaActual;
                }
                else
                {
                    // Si no es el primer dia de la simulacion se mira si el dia de arreglo es menor o igual al dia de mantenimiento (no los que faltan para llegar a esa fecha, sino el dia efectivo de arreglo y mantenimiento), esto coincide con lo que dice el enunciado de que si se rompe antes del mantenimiento se arregla y se reinicia el ciclo
                    // Tambien aclara que si se rompe el mismo dia del mantenimiento se toma el arreglo y no el mantenimiento por tanto se pone la condicion igual
                    if (filaAnterior.Item4 <= filaAnterior.Item6 )
                    {


                        filaActual = SimularReparacion(rand, desde, hasta, i, filaActual, filaAnterior, preventivo);
                        filaAnterior = filaActual;

                    }

                    //Esto quiere decir que el dia donde se va a romper es mayor al dia del mantenimiento, por tanto el mantenimiento ocurrira primero y no se efectuara el arreglo
                    else {


                        // la fila actual sera el resultado de simular el mantenimiento para la misma
                        filaActual = SimularMantenimiento(rand, desde, hasta, i, filaActual, filaAnterior, preventivo);
                        filaAnterior = filaActual;




                    }
                }



                // Si el dia es el ultimo se devuelve siempre porque es lo que pide el enunciado
                if (i == cant)
                {
                    if (i > hasta)
                    {
                        EstablecerFilaDataGridView(preventivo, filaActual);
                    }
                    
                    Program.acumPreventivo = filaActual.Item13;
                }




            }




            
        }
    }
}
