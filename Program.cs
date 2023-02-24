//Entregable 1-L-W
//Presentado por: Alejandra Orrego, Cristian rios, yureixon , Juan garcia.

//Menu con los 4 Ejercicios

int opc = 0;
String menu = "\n1) Ejercicio 1  La renta\n"
+ "2) Ejercicio 2 Sala de juegos\n"
+ "3) Ejercicio 3 La pizzería\n"
+ "4) Ejercicio 4 Empleados premiados\n"
+ "0) Salir del sistema\n";
do
{
    Console.WriteLine("\nIngresa una opción\n" + menu);
    opc = Int32.Parse(Console.ReadLine());
    switch (opc)
    {
        case 1://realizado por yureixon 
            int[] valoresT = new int[4];
            int suma = 0;
            double impuesto = 0;

            for (int i = 0; i <= valoresT.Length - 1; i++)
            {
                Console.WriteLine("");
                Console.WriteLine("Ingrese Valor del Trimestre: " + (i + 1));
                valoresT[i] = Int32.Parse(Console.ReadLine());
                suma = suma + valoresT[i];
                Console.WriteLine("");
            }

            if (suma < 10000)
            {
                impuesto = 0.05;
            }

            if (suma >= 10000 && suma < 20000)
            {
                impuesto = 0.1;
            }

            if (suma >= 20000 && suma < 35000)
            {
                impuesto = 0.15;
            }

            if (suma >= 35000 && suma < 45000)
            {
                impuesto = 0.2;
            }

            if (suma > 45000)
            {
                impuesto = 0.3;
            }
            Console.WriteLine("*****************************************");
            Console.WriteLine("Renta Anual: " + suma + "\nTotal Renta a pagar: "
            + (/*suma+*/(suma * impuesto)) + "\nPorcentaje de Impuesto agregado: "
            + impuesto * 100 + "%"/*+"Equivalente a: "+suma*impuesto*/);
            Console.WriteLine("*****************************************");
            break;
        case 2://realizado por Cristian 
            Console.WriteLine("");
            Console.WriteLine("Ingrese su nombre completo: ");
            string nombreCompleto = Console.ReadLine();
            Console.WriteLine("Ingrese su edad: ");
            int edad = int.Parse(Console.ReadLine());

            double precioEntrada = 15000;
            double descuento = 0;
            if (edad < 4)
            {
                precioEntrada = 0;
            }
            else if (edad >= 4 && edad <= 18)
            {
                descuento = 0.05;
            }
            else
            {
                descuento = 0.03;
            }
            precioEntrada = precioEntrada - (precioEntrada * descuento);

            Console.WriteLine("*****************************************");
            Console.WriteLine("Nombre completo: " + nombreCompleto);
            Console.WriteLine("Precio de la entrada: " + precioEntrada);
            Console.WriteLine("Descuento: " + descuento * 100 + "%");
            Console.WriteLine("*****************************************");
            break;
        case 3://realizado por Juan
            Console.WriteLine("Bienvenido a PIZZAS EL FERCHO... \n");

            string vegeingredientes = "1) Pimiento," + " 2) Champiñones";
            string Novegeingredientes = "1) Pepperoni," + " 2) Salami," + " 3) Pollo";

            Console.WriteLine("¿Desea una pizza vegetariana o no vegetariana?\n(responder: '1) para vegetariana' o '2)para  no vegetariana'): ");
            int opcion = Int32.Parse(Console.ReadLine());

            if (opcion == 1)
            {
                Console.WriteLine("Los ingredientes disponibles para la pizza vegetariana son: " + vegeingredientes);
                Console.WriteLine("Elija uno de los ingredientes anteriores para agregar a su pizza: (responder con números)");
                int res_ingredientes = Int32.Parse(Console.ReadLine());
                string ingrediente="";
                //validar ingredientes
                if (res_ingredientes==1)
                {
                    ingrediente="Pimiento";
                }else if(res_ingredientes==2){
                    ingrediente="Champiñones";
                }else{
                    Console.WriteLine("Ingrediente no valido solo hay 1) Pimiento y 2) Champiñones");
                    Environment.Exit(1);
                }
                Console.WriteLine("");
                Console.WriteLine("*****************************************");
                Console.WriteLine("Usted eligió una pizza vegetariana con los siguientes ingredientes: " + "Mozzarella" + " Tomate " + ingrediente + " \nEn un momento sale su pedido...");
                Console.WriteLine("*****************************************");
            }
            else if(opcion == 2)
            {
                Console.WriteLine("Los ingredientes disponibles para la pizza no vegetariana son: " + Novegeingredientes);
                Console.WriteLine("Elija uno de los ingredientes anteriores para agregar a su pizza: (responder con números)");
                int res_ingredientes2 = Int32.Parse(Console.ReadLine());
                String ingrediente="";
                //validar ingredientes
                if (res_ingredientes2==1)
                {
                    ingrediente="Pepperoni";
                }else if(res_ingredientes2==2){
                    ingrediente="Salami";
                }else if(res_ingredientes2==3){
                    ingrediente="Pollo";
                }else{
                    Console.WriteLine("Ingrediente no valido solo hay 1) Pepperoni , 2) Salami y 3) Pollo");
                    Environment.Exit(1);
                }
                Console.WriteLine("*****************************************");
                Console.WriteLine("Usted eligió una pizza No vegetariana con los siguientes ingredientes: " + "Mozzarella" + " Tomate " + ingrediente + " \nEn un momento sale su pedido...");
                Console.WriteLine("*****************************************");
            }else{
                Console.WriteLine("*****************************************");
                Console.WriteLine("Opción de pizza no valida: solo hay pizza 1) Vegetariana y 2) no vegetariana");
                Console.WriteLine("*****************************************");
            }

            break;
        case 4://realizado por Alejandra
            Console.WriteLine("");
            float puntos = 0;
            String nivel = "";
            bool cumple = false;
            int BONO = 50000;

            do
            {
                Console.WriteLine("Ingresa Los puntos que gano el empleado por su rendimiento: ");
                puntos = float.Parse(Console.ReadLine());
                switch (puntos)
                {
                    case 0.0f:
                        nivel = "Inaceptable";
                        cumple = true;
                        break;
                    case 0.4f:
                        nivel = "Aceptable";
                        cumple = true;
                        break;
                    case 0.6f:
                        nivel = "Meritorio";
                        cumple = true;
                        break;
                    default:
                        Console.WriteLine("\nLos puntos validos" +
                        " para la evaluación son: 0,0--0,4-- y 0,6.");
                        cumple = false;
                        break;
                }
            } while (!cumple);//Cuando cumpla las condiciones

            Console.WriteLine("");
            Console.WriteLine("*****************************************");
            Console.WriteLine("Tu nivel de Evaluación es: " + nivel + "\nLa bonificación ganada" +
            " Por tu rendimiento es: " + Math.Round(BONO * puntos));
            Console.WriteLine("*****************************************");
            break;
        case 0://realizado por Alejandra
            Environment.Exit(0);
            break;

        default:
            Console.WriteLine("Opción No disponible, Intentelo de nuevo");
            break;
    }
} while (true);