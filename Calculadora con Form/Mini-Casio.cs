namespace Calculadora_con_Form
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        List<string> dataUnitario = new List<string>();
        List<double> dataConjunto = new List<double>();
        List<string> operacion = new List<string>();
        string Unitario = string.Empty;
        double resultado = 0;

        List<string> operacionpot = new List<string>();
        List<string> dataUnitPot = new List<string>();
        List<double> dataConjPot = new List<double>();
        string UnitarioPot = string.Empty;
        double resultadopot = 0;

        string botonEspecial = "Defect";
        string validacion = "";
        string command = "";
        string especialesbtn = "";
        string pi_touch = "";



        // ---------------------------------------------------------- Botones Numericos ----------------------------------------------------------- //

        private void btnUno_Click(object sender, EventArgs e)
        {
            //Impresion en la pantalla y guardado de datos
            if (command == "")
            {
                dataUnitario.Add("1");
                txtContain.Text = txtContain.Text + "1";
            }
            else if (command == "Expo") // con expo se puede agregar operaciones basicas
            {
                dataUnitario.Add("1");
                txtContain.Text = txtContain.Text + "¹";
            }
            else if (command == "Pot") // Con pot no se podra añadir operaciones
            {
                dataUnitPot.Add("1");
                txtContain.Text = txtContain.Text + "¹";
            }

            //Habilitando calculadora completa
            if (especialesbtn == "no-repeat")
            {
                No_Repeat_Habilitador();
            }
            else if (especialesbtn == "porcentaje")
            {
                Porcentaje_Hab();
            }
            else
            {
                Basic_Habilitador();
            }

        }

        private void btnDos_Click(object sender, EventArgs e)
        {
            //Impresion en la pantalla y guardado de datos
            if (command == "")
            {
                dataUnitario.Add("2");
                txtContain.Text = txtContain.Text + "2";
            }
            else if (command == "Expo") // con expo se puede agregar operaciones basicas
            {
                dataUnitario.Add("2");
                txtContain.Text = txtContain.Text + "²";
            }
            else if (command == "Pot") // Con pot no se podra añadir operaciones
            {
                dataUnitPot.Add("2");
                txtContain.Text = txtContain.Text + "²";
            }

            //Habilitando calculadora completa
            if (especialesbtn == "no-repeat")
            {
                No_Repeat_Habilitador();
            }
            else if(especialesbtn == "porcentaje")
            {
                Porcentaje_Hab();
            }
            else
            {
                Basic_Habilitador();
            }

        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            //Impresion en la pantalla y guardado de datos
            if (command == "")
            {
                dataUnitario.Add("3");
                txtContain.Text = txtContain.Text + "3";
            }
            else if (command == "Expo") // con expo se puede agregar operaciones basicas
            {
                dataUnitario.Add("3");
                txtContain.Text = txtContain.Text + "³";
            }
            else if (command == "Pot") // Con pot no se podra añadir operaciones
            {
                dataUnitPot.Add("3");
                txtContain.Text = txtContain.Text + "³";
            }

            //Habilitando calculadora completa
            if (especialesbtn == "no-repeat")
            {
                No_Repeat_Habilitador();
            }
            else if (especialesbtn == "porcentaje")
            {
                Porcentaje_Hab();
            }
            else
            {
                Basic_Habilitador();
            }

        }

        private void btnCuatro_Click(object sender, EventArgs e)
        {
            //Impresion en la pantalla y guardado de datos
            if (command == "")
            {
                dataUnitario.Add("4");
                txtContain.Text = txtContain.Text + "4";
            }
            else if (command == "Expo") // con expo se puede agregar operaciones basicas
            {
                dataUnitario.Add("4");
                txtContain.Text = txtContain.Text + "⁴";
            }
            else if (command == "Pot") // Con pot no se podra añadir operaciones
            {
                dataUnitPot.Add("4");
                txtContain.Text = txtContain.Text + "⁴";
            }

            //Habilitando calculadora completa
            if (especialesbtn == "no-repeat")
            {
                No_Repeat_Habilitador();
            }
            else if (especialesbtn == "porcentaje")
            {
                Porcentaje_Hab();
            }
            else
            {
                Basic_Habilitador();
            }

        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            //Impresion en la pantalla y guardado de datos
            if (command == "")
            {
                dataUnitario.Add("5");
                txtContain.Text = txtContain.Text + "5";
            }
            else if (command == "Expo") // con expo se puede agregar operaciones basicas
            {
                dataUnitario.Add("5");
                txtContain.Text = txtContain.Text + "⁵";
            }
            else if (command == "Pot") // Con pot no se podra añadir operaciones
            {
                dataUnitPot.Add("5");
                txtContain.Text = txtContain.Text + "⁵";
            }

            //Habilitando calculadora completa
            if (especialesbtn == "no-repeat")
            {
                No_Repeat_Habilitador();
            }
            else if (especialesbtn == "porcentaje")
            {
                Porcentaje_Hab();
            }
            else
            {
                Basic_Habilitador();
            }

        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            //Impresion en la pantalla y guardado de datos
            if (command == "")
            {
                dataUnitario.Add("6");
                txtContain.Text = txtContain.Text + "6";
            }
            else if (command == "Expo") // con expo se puede agregar operaciones basicas
            {
                dataUnitario.Add("6");
                txtContain.Text = txtContain.Text + "⁶";
            }
            else if (command == "Pot") // Con pot no se podra añadir operaciones
            {
                dataUnitPot.Add("6");
                txtContain.Text = txtContain.Text + "⁶";
            }

            //Habilitando calculadora completa
            if(especialesbtn == "no-repeat")
            {
                No_Repeat_Habilitador();
            }
            else if (especialesbtn == "porcentaje")
            {
                Porcentaje_Hab();
            }
            else
            {
                Basic_Habilitador();
            }

        }

        private void btnSiete_Click(object sender, EventArgs e)
        {
            //Impresion en la pantalla y guardado de datos
            if (command == "")
            {
                dataUnitario.Add("7");
                txtContain.Text = txtContain.Text + "7";
            }
            else if (command == "Expo") // con expo se puede agregar operaciones basicas
            {
                dataUnitario.Add("7");
                txtContain.Text = txtContain.Text + "⁷";
            }
            else if (command == "Pot") // Con pot no se podra añadir operaciones
            {
                dataUnitPot.Add("7");
                txtContain.Text = txtContain.Text + "⁷";
            }

            //Habilitando calculadora completa
            if (especialesbtn == "no-repeat")
            {
                No_Repeat_Habilitador();
            }
            else if (especialesbtn == "porcentaje")
            {
                Porcentaje_Hab();
            }
            else
            {
                Basic_Habilitador();
            }

        }

        private void btnOcho_Click(object sender, EventArgs e)
        {
            //Impresion en la pantalla y guardado de datos
            if (command == "")
            {
                dataUnitario.Add("8");
                txtContain.Text = txtContain.Text + "8";
            }
            else if (command == "Expo") // con expo se puede agregar operaciones basicas
            {
                dataUnitario.Add("8");
                txtContain.Text = txtContain.Text + "⁸";
            }
            else if (command == "Pot") // Con pot no se podra añadir operaciones
            {
                dataUnitPot.Add("8");
                txtContain.Text = txtContain.Text + "⁸";
            }

            //Habilitando calculadora completa
            if (especialesbtn == "no-repeat")
            {
                No_Repeat_Habilitador();
            }
            else if (especialesbtn == "porcentaje")
            {
                Porcentaje_Hab();
            }
            else
            {
                Basic_Habilitador();
            }

        }

        private void btnNueve_Click(object sender, EventArgs e)
        {
            //Impresion en la pantalla y guardado de datos
            if (command == "")
            {
                dataUnitario.Add("9");
                txtContain.Text = txtContain.Text + "9";
            }
            else if(command == "Expo") // con expo se puede agregar operaciones basicas
            {
                dataUnitario.Add("9");
                txtContain.Text = txtContain.Text + "⁹";
            }
            else if(command == "Pot") // Con pot no se podra añadir operaciones
            {
                dataUnitPot.Add("9");
                txtContain.Text = txtContain.Text + "⁹";
            }

            //Habilitando calculadora completa
            if (especialesbtn == "no-repeat")
            {
                No_Repeat_Habilitador();
            }
            else if (especialesbtn == "porcentaje")
            {
                Porcentaje_Hab();
            }
            else
            {
                Basic_Habilitador();
            }

        }


        private void btnCero_Click(object sender, EventArgs e)
        {
            //Impresion en la pantalla y guardado de datos
            if (command == "")
            {
                dataUnitario.Add("0");
                txtContain.Text = txtContain.Text + "0";
            }
            else if (command == "Expo") // con expo se puede agregar operaciones basicas
            {
                dataUnitario.Add("0");
                txtContain.Text = txtContain.Text + "⁰";
            }
            else if (command == "Pot") // Con pot no se podra añadir operaciones
            {
                dataUnitPot.Add("0");
                txtContain.Text = txtContain.Text + "⁰";
            }

            //Habilitando calculadora completa
            if(especialesbtn == "no-repeat")
            {
                No_Repeat_Habilitador();
            }
            else if (especialesbtn == "porcentaje")
            {
                Porcentaje_Hab();
            }
            else
            {
                Basic_Habilitador();
            }

        }

        private void btnPi_Click(object sender, EventArgs e)
        {
            pi_touch = "pi";
            //Impresion en la pantalla y guardado de datos
            if (command == "")
            {
                dataUnitario.Add("3.14159265");
                txtContain.Text = txtContain.Text + "π";
            }
            else if (command == "Expo") // con expo se puede agregar operaciones basicas
            {
                dataUnitario.Add("3.14159265");
                txtContain.Text = txtContain.Text + "ᵀᵀ";
            }
            else if (command == "Pot") // Con pot no se podra añadir operaciones
            {
                dataUnitPot.Add("3.14159265");
                txtContain.Text = txtContain.Text + "ᵀᵀ";
            }


            // Habilitando calculadora completa
            if (especialesbtn == "no-repeat")
            {
                No_Repeat_Pi();
            }
            else if (especialesbtn == "porcentaje")
            {
                Porcentaje_Pi();
            }
            else
            {
                Pi_Habilitador();
            }
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            //Impresion en la pantalla y guardado de datos
            if (command == "")
            {
                dataUnitario.Add(".");
                txtContain.Text = txtContain.Text + ".";
            }
            else if (command == "Expo") // con expo se puede agregar operaciones basicas
            {
                dataUnitario.Add(".");
                txtContain.Text = txtContain.Text + "·";
            }
            else if (command == "Pot") // Con pot no se podra añadir operaciones
            {
                dataUnitPot.Add(".");
                txtContain.Text = txtContain.Text + "·";
            }

            // Desabilitando el uso del doble punto
            if (especialesbtn == "no-repeat")
            {
                Punto_No_Repeat();
            }
            else
            {
                Punto_Habilitador();
            }
        }

        private void btnAC_Click(object sender, EventArgs e)
        {
            // Eliminando todo
            txtContain.Text = "";
            command = "";
            validacion = "";
            botonEspecial = "Defect";
            especialesbtn = "";
            LimpiezaDeDatos();
            LimpiezaDeConjunto();
            LimpiezaDeDatosPot();
            LimpiezaDeConjuntoPot();
            Reset_Calculadora();
        }

        // ---------------------------------------------- Funciones Operacionales ----------------------------------------------------- //

        public void AlmacenDeDatos()
        {
            // Almacenando dato en Lista de conjunto

            foreach (var item in dataUnitario)
            {
                Unitario = Unitario + item;
            }
            //MessageBox.Show(Unitario);
            dataConjunto.Add(double.Parse(Unitario));
        }
        public void AlmacenDeDatosPot()
        {
            // Almacenando dato en Lista de conjunto

            foreach (var item in dataUnitPot)
            {
                UnitarioPot = UnitarioPot + item;
            }
            //MessageBox.Show(UnitarioPot);
            dataConjPot.Add(double.Parse(UnitarioPot));
        }
        public void LimpiezaDeDatos()
        {
            // Limpieza de mediadores
            dataUnitario.Clear();
            Unitario = string.Empty;
        }
        public void LimpiezaDeDatosPot()
        {
            // Limpieza de mediadores
            dataUnitPot.Clear();
            UnitarioPot = string.Empty;
        }
        public void LimpiezaDeConjunto()
        {
            //Limpieza del conjunto solo usado en btnResultado
            resultado = 0;
            dataConjunto.Clear();
            operacion.Clear();
        }
        public void LimpiezaDeConjuntoPot()
        {
            //Limpieza del conjunto solo usado en btnResultado
            resultadopot = 0;
            dataConjPot.Clear();
            operacionpot.Clear();
        }
        // --------------------------------------------------------------------------------------------------------------------------- //
        // --------------------------------------------------------------------------------------------------------------------------- //
        // --------------------------------------------------------------------------------------------------------------------------- //
        public void CalculoResultado()
        {
            //Primera operación          
            for (int i = 0; i < 1; i++)
            {
                if (operacion.Count > 0)
                {
                    switch (operacion[i])
                    {
                        case "+":
                            resultado = dataConjunto[0] + dataConjunto[1];
                            break;
                        case "-":
                            resultado = dataConjunto[0] - dataConjunto[1];
                            break;
                        case "*":
                            resultado = dataConjunto[0] * dataConjunto[1];
                            break;
                        case "/":
                            if (dataConjunto[1] != 0)
                            {
                                resultado = dataConjunto[0] / dataConjunto[1];
                            }
                            else
                            {
                                MessageBox.Show("Se ha producido un error al tratar de dividir entre 0", "Error del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                validacion = "error";
                            }
                            break;
                        case "%":
                            resultado = dataConjunto[0] * (dataConjunto[1] / 100);
                            break;
                        default:
                            MessageBox.Show("Error de ingreso de simbolo en ciclo 1");
                            break;
                    }
                }
                else
                {
                    resultado = dataConjunto[0];
                }
            }
            //Siguientes operaciones
            for (int i = 1; i < operacion.Count; i++)
            {
                switch (operacion[i])
                {
                    case "+":
                        resultado = resultado + dataConjunto[i + 1];
                        break;
                    case "-":
                        resultado = resultado - dataConjunto[i + 1];
                        break;
                    case "*":
                        resultado = resultado * dataConjunto[i + 1];
                        break;
                    case "/":
                        if (dataConjunto[ i + 1] != 0)
                        {
                            resultado = resultado / dataConjunto[i + 1];
                        }
                        else
                        {
                            MessageBox.Show("Se ha producido un error al tratar de dividir entre 0", "Error del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            validacion = "error";
                        }
                        break;
                    default:
                        MessageBox.Show("Error de ingreso de simbolo en ciclo 2");
                        break;
                }
            }
        }
        public void CalculoResultadoPot()
        {
            //Primera operación          
            for (int i = 0; i < 1; i++)
            {
                if (operacionpot.Count > 0)
                {
                    switch (operacionpot[i])
                    {
                        case "+":
                            resultadopot = dataConjPot[0] + dataConjPot[1];
                            break;
                        case "-":
                            resultadopot = dataConjPot[0] - dataConjPot[1];
                            break;
                        case "*":
                            resultadopot = dataConjPot[0] * dataConjPot[1];
                            break;
                        case "/":
                            if (dataConjPot[1] != 0)
                            {
                                resultadopot = dataConjPot[0] / dataConjPot[1];
                            }
                            else
                            {
                                MessageBox.Show("Se ha producido un error al tratar de dividir entre 0", "Error del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                validacion = "error";
                            }
                            break;
                        default:
                            MessageBox.Show("Error de ingreso de simbolo en ciclo 1");
                            break;
                    }
                }
                else
                {
                    resultadopot = dataConjPot[0];
                }
            }
            //Siguientes operaciones
            for (int i = 1; i < operacionpot.Count; i++)
            {
                switch (operacionpot[i])
                {
                    case "+":
                        resultadopot = resultadopot + dataConjPot[i + 1];
                        break;
                    case "-":
                        resultadopot = resultadopot - dataConjPot[i + 1];
                        break;
                    case "*":
                        resultadopot = resultadopot * dataConjPot[i + 1];
                        break;
                    case "/":
                        if(dataConjPot[ i + 1] != 0)
                        {
                            resultadopot = resultadopot / dataConjPot[i + 1];
                        }
                        else
                        {
                            MessageBox.Show("Se ha producido un error al tratar de dividir entre 0", "Error del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            validacion = "error";
                        }
                        break;
                    default:
                        MessageBox.Show("Error de ingreso de simbolo en ciclo 2");
                        break;
                }
            }
        }
        // --------------------------------------------------------------------------------------------------------------------------- //
        // --------------------------------------------------------------------------------------------------------------------------- //
        // --------------------------------------------------------------------------------------------------------------------------- //

        public void ImpresionResultado(double result)
        {
            if (validacion == "")
            {
                txtContain.Text = "= " + Math.Round(result, 6);
            }
            else if (validacion == "error")
            {
                txtContain.Text = "Math ERROR";
            }
            else if (validacion == "errorS")
            {
                txtContain.Text = "Syntax ERROR";
            }
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            // Inserción del ultimo numero ingresado
            AlmacenDeDatos();
            LimpiezaDeDatos();

            // Calculos general de resultado
            CalculoResultado();

            // Calculos signos base
            if (botonEspecial == "Defect")
            {
                ImpresionResultado(resultado);
            }
            // Calculo del logaritmo base 10
            else if (botonEspecial == "LogBase10")
            {
                double resultadoLog;
                if (resultado > 0)
                {
                    resultadoLog = Math.Log10(resultado);
                    ImpresionResultado(resultadoLog);
                }
                else
                {
                    MessageBox.Show("Se ha excedido el limite del calculo del Logaritmo base 10", "Error del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtContain.Text = "Math ERROR";
                }
            }
            // Calculo del logaritmo natural
            else if (botonEspecial == "LogNatural")
            {
                double resultadoLn;
                if (resultado > 0)
                {
                    resultadoLn = Math.Log(resultado);
                    ImpresionResultado(resultadoLn);
                }
                else
                {
                    MessageBox.Show("Se ha excedido el limite del calculo del Logaritmo natural", "Error del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtContain.Text = "Math ERROR";
                }
            }
            // Calculo del exponencial
            else if (botonEspecial == "Expo")
            {
                double resultadoexp;
                if (resultado <= 230.2585)
                {
                    resultadoexp = Math.Exp(resultado);
                    ImpresionResultado(resultadoexp);
                }
                else
                {
                    MessageBox.Show("Se ha excedido el limite a la que se puede elevar el exponencial", "Error del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtContain.Text = "Math ERROR";
                }
            }
            // Calculo del Seno
            else if (botonEspecial == "Seno")
            {
                double resultadosin;
                resultadosin = Math.Sin(resultado);
                ImpresionResultado(resultadosin);
            }
            // Calculo del Coseno
            else if (botonEspecial == "Coseno")
            {
                double resultadocos;
                resultadocos = Math.Cos(resultado);
                ImpresionResultado(resultadocos);
            }
            // Calculo de la Tangente
            else if (botonEspecial == "Tangente")
            {
                double resultadotan;
                resultadotan = Math.Tan(resultado);
                ImpresionResultado(resultadotan);
            }
            // Calculo del exponente cuadrado en su boton
            else if (botonEspecial == "Cuadrado")
            {
                double resultadocuad;
                resultadocuad = Math.Pow(resultado, 2);
                ImpresionResultado(resultadocuad);
            }
            // Calculo del exponente cubico
            else if (botonEspecial == "Cubo")
            {
                double resultadocubo;
                resultadocubo = Math.Pow(resultado, 3);
                ImpresionResultado(resultadocubo);
            }
            else if (botonEspecial == "Potencia")
            {
                if (validacion == "")
                {
                    AlmacenDeDatosPot();
                    LimpiezaDeDatosPot();
                    CalculoResultadoPot();

                    double resultpotencia;
                    resultpotencia = Math.Pow(resultado, resultadopot);
                    ImpresionResultado(resultpotencia);
                }
                else
                {
                    txtContain.Text = "Math ERROR";
                }
            }
            else if(botonEspecial == "Raiz")
            {
                double resultadoraiz;
                resultadoraiz = Math.Sqrt(resultado);
                ImpresionResultado(resultadoraiz);
            }
            else if(botonEspecial == "Absoluto")
            {
                double resultadoabs;
                resultadoabs = Math.Abs(resultado);
                ImpresionResultado(resultadoabs);
            }
            else if(botonEspecial == "Factorial")
            {
                long acumulador = 1L, restando = 1;
                string resultstring = resultado.ToString();
                long variable;
                if (Int64.TryParse(resultstring, out variable)){
                    acumulador = long.Parse(resultstring);
                    for(long k = long.Parse(resultstring); k > 0; k--)
                    {
                        if (restando < long.Parse(resultstring))
                        {
                            acumulador = acumulador * (long.Parse(resultstring) - restando);
                            restando++;
                        }
                    }
                    ImpresionResultado(acumulador);
                }
                else
                {
                    MessageBox.Show("No se puede calcular un factorial de un decimal", "Error del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    validacion = "error";
                    ImpresionResultado(resultado);
                }
            }


            // Desabilitando todos los botones
            Desabilitador_General();
            LimpiezaDeConjunto();
            LimpiezaDeConjuntoPot();
            

        }

        // ---------------------------------------------------- Botones Generales ---------------------------------------------------- //
        private void btnSuma_Click(object sender, EventArgs e)
        {
            // Impresion en la pantalla y calculo
            if (command == "")
            {
                AlmacenDeDatos();
                operacion.Add("+");
                LimpiezaDeDatos();
                txtContain.Text = txtContain.Text + "+";


            }
            else if (command == "Expo")
            {
                AlmacenDeDatos();
                operacion.Add("+");
                LimpiezaDeDatos();
                txtContain.Text = txtContain.Text + "⁺";
            }
            else if (command == "Pot")
            {
                AlmacenDeDatosPot();
                operacionpot.Add("+");
                LimpiezaDeDatosPot();
                txtContain.Text = txtContain.Text + "⁺";
            }
            general_hab();
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            // Impresion en la pantalla y calculo
            if (command == "")
            {
                AlmacenDeDatos();
                operacion.Add("-");
                LimpiezaDeDatos();
                txtContain.Text = txtContain.Text + "-";
            }
            else if (command == "Expo")
            {
                AlmacenDeDatos();
                operacion.Add("-");
                LimpiezaDeDatos();
                txtContain.Text = txtContain.Text + "⁻";
            }
            else if (command == "Pot")
            {
                AlmacenDeDatosPot();
                operacionpot.Add("-");
                LimpiezaDeDatosPot();
                txtContain.Text = txtContain.Text + "⁻";
            }
            general_hab();
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            // Impresion en la pantalla y calculo
            if (command == "")
            {
                AlmacenDeDatos();
                operacion.Add("*");
                LimpiezaDeDatos();
                txtContain.Text = txtContain.Text + "×";
            }
            else if (command == "Expo")
            {
                AlmacenDeDatos();
                operacion.Add("*");
                LimpiezaDeDatos();
                txtContain.Text = txtContain.Text + "ˣ";
            }
            else if (command == "Pot")
            {
                AlmacenDeDatosPot();
                operacionpot.Add("*");
                LimpiezaDeDatosPot();
                txtContain.Text = txtContain.Text + "ˣ";
            }
            general_hab();
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            // Impresion en la pantalla y calculo
            if (command == "")
            {
                AlmacenDeDatos();
                operacion.Add("/");
                LimpiezaDeDatos();
                txtContain.Text = txtContain.Text + "÷";
            }
            else if (command == "Expo")
            {
                AlmacenDeDatos();
                operacion.Add("/");
                LimpiezaDeDatos();
                txtContain.Text = txtContain.Text + "ᐟ";
            }
            else if (command == "Pot")
            {
                AlmacenDeDatosPot();
                operacionpot.Add("/");
                LimpiezaDeDatosPot();
                txtContain.Text = txtContain.Text + "ᐟ";
            }
            general_hab();
        }

        private void btnPorcentaje_Click(object sender, EventArgs e)
        {
            AlmacenDeDatos();
            operacion.Add("%");                       // Habilitador especifico para solo ingresar un numero mas
            LimpiezaDeDatos();
            especialesbtn = "porcentaje";

            general_hab();

            // Impresion en pantalla
            txtContain.Text = txtContain.Text + "%";
        }

        // ---------------------------------------------------- Botones Especiales ---------------------------------------------------- //

        private void btnLog_Click(object sender, EventArgs e)
        {
            
            botonEspecial = "LogBase10";
            txtContain.Text = "Log(";

            especialesbtn = "no-repeat";
            Op_Desabilitador();
        }

        private void btnLn_Click(object sender, EventArgs e)
        {
            botonEspecial = "LogNatural";
            txtContain.Text = "Ln(";

            especialesbtn = "no-repeat";
            Op_Desabilitador();
        }

        private void btnExp_Click(object sender, EventArgs e)
        {
            botonEspecial = "Expo";
            command = "Expo";
            txtContain.Text = "e^⁽";

            especialesbtn = "no-repeat";
            Op_Desabilitador();
        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            botonEspecial = "Seno";
            txtContain.Text = "Sin(";

            especialesbtn = "no-repeat";
            Op_Desabilitador();
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            botonEspecial = "Coseno";
            txtContain.Text = "Cos(";

            especialesbtn = "no-repeat";
            Op_Desabilitador();
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            botonEspecial = "Tangente";
            txtContain.Text = "Tan(";

            especialesbtn = "no-repeat";
            Op_Desabilitador();
        }

        private void btnCuadrado_Click(object sender, EventArgs e)
        {
            botonEspecial = "Cuadrado";
            txtContain.Text = "(" + txtContain.Text + ")^²";

            especialesbtn = "no-repeat";
            Op_Desabilitador();
        }

        private void btnCubico_Click(object sender, EventArgs e)
        {
            botonEspecial = "Cubo";
            txtContain.Text = "(" + txtContain.Text + ")^³";

            especialesbtn = "no-repeat";
            Op_Desabilitador();
        }

        private void btnPotencia_Click(object sender, EventArgs e)
        {
            
            botonEspecial = "Potencia";
            txtContain.Text = "(" + txtContain.Text + ")^";
            command = "Pot";

            especialesbtn = "no-repeat";
            if (pi_touch == "")
            {
                Op_Desabilitador();
            }
            else
            {
                Op_Desabilitador();
                btnPi.Enabled = true;
                btnUno.Enabled = true;
                btnDos.Enabled = true;
                btnTres.Enabled = true;
                btnCuatro.Enabled = true;
                btnCinco.Enabled = true;
                btnSeis.Enabled = true;
                btnSiete.Enabled = true;
                btnOcho.Enabled = true;
                btnNueve.Enabled = true;
                btnCero.Enabled = true;

            }
        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            botonEspecial = "Raiz";
            txtContain.Text = "√(";

            especialesbtn = "no-repeat";
            Op_Desabilitador();
        }

        private void btnAbsoluto_Click(object sender, EventArgs e)
        {
            botonEspecial = "Absoluto";
            txtContain.Text = "Abs(";

            especialesbtn = "no-repeat";
            Op_Desabilitador();
        }

        private void btnFactorial_Click(object sender, EventArgs e)
        {
            botonEspecial = "Factorial";
            txtContain.Text = "(" + txtContain.Text + ")!";

            especialesbtn = "no-repeat";
            Op_Desabilitador();
        }

        // ------------------------------------------ Control de Enabled Buttons ----------------------------------------------------- //

        public void Op_Desabilitador()  // No permite repetir doble boton especial
        {
            btnPorcentaje.Enabled = false;
            btnLog.Enabled = false;
            btnLn.Enabled = false;
            btnExp.Enabled = false;
            btnSin.Enabled = false;
            btnCos.Enabled = false;
            btnTan.Enabled = false;
            btnCuadrado.Enabled = false;
            btnCubico.Enabled = false;
            btnPotencia.Enabled = false;
            btnRaiz.Enabled = false;
            btnAbsoluto.Enabled = false;
            btnFactorial.Enabled = false;
        }
        public void Basic_Habilitador()   // Habilita operadores y botones especiales que requieren numero inicial
        {
            btnPunto.Enabled = true;
            btnSuma.Enabled = true;
            btnResta.Enabled = true;
            btnDivision.Enabled = true;
            btnMultiplicacion.Enabled = true;
            btnPorcentaje.Enabled = true;
            btnResultado.Enabled = true;
            btnPi.Enabled = false;

            btnCuadrado.Enabled = true;
            btnCubico.Enabled = true;
            btnPotencia.Enabled = true;
            btnFactorial.Enabled = true;
        }
        public void No_Repeat_Habilitador() // Habilita operadores pero no botones especiales porque ya hay uno en ejecucion
        {
            btnPunto.Enabled = true;
            btnSuma.Enabled = true;
            btnResta.Enabled = true;
            btnDivision.Enabled = true;
            btnMultiplicacion.Enabled = true;
            btnResultado.Enabled = true;
            btnPi.Enabled = false;

            btnCuadrado.Enabled = false;
            btnCubico.Enabled = false;
            btnPotencia.Enabled = false;
            btnFactorial.Enabled = false;
            btnLog.Enabled = false;
            btnLn.Enabled = false;
            btnExp.Enabled = false;
            btnSin.Enabled = false;
            btnCos.Enabled = false;
            btnTan.Enabled = false;
            btnRaiz.Enabled = false;
            btnAbsoluto.Enabled = false;
            btnFactorial.Enabled = false;
        }
        public void Pi_Habilitador()
        {
            btnPi.Enabled = false;
            btnPunto.Enabled = false;
            btnUno.Enabled = false;
            btnDos.Enabled = false;
            btnTres.Enabled = false;
            btnCuatro.Enabled = false;
            btnCinco.Enabled = false;
            btnSeis.Enabled = false;
            btnSiete.Enabled = false;
            btnOcho.Enabled = false;
            btnNueve.Enabled = false;
            btnCero.Enabled = false;

            btnSuma.Enabled = true;
            btnResta.Enabled = true;
            btnDivision.Enabled = true;
            btnMultiplicacion.Enabled = true;
            btnPorcentaje.Enabled = true;
            btnResultado.Enabled = true;

            btnCuadrado.Enabled = true;
            btnCubico.Enabled = true;
            btnPotencia.Enabled = true;
            btnFactorial.Enabled = true;
        }
        public void No_Repeat_Pi()
        {
            btnPi.Enabled = false;
            btnPunto.Enabled = false;
            btnUno.Enabled = false;
            btnDos.Enabled = false;
            btnTres.Enabled = false;
            btnCuatro.Enabled = false;
            btnCinco.Enabled = false;
            btnSeis.Enabled = false;
            btnSiete.Enabled = false;
            btnOcho.Enabled = false;
            btnNueve.Enabled = false;
            btnCero.Enabled = false;

            btnSuma.Enabled = true;
            btnResta.Enabled = true;
            btnDivision.Enabled = true;
            btnMultiplicacion.Enabled = true;
            btnResultado.Enabled = true;

            btnCuadrado.Enabled = false;
            btnCubico.Enabled = false;
            btnPotencia.Enabled = false;
            btnFactorial.Enabled = false;
            btnLog.Enabled = false;
            btnLn.Enabled = false;
            btnExp.Enabled = false;
            btnSin.Enabled = false;
            btnCos.Enabled = false;
            btnTan.Enabled = false;
            btnRaiz.Enabled = false;
            btnAbsoluto.Enabled = false;
            btnFactorial.Enabled = false;


        }
        public void Punto_Habilitador()
        {
            btnPi.Enabled = false;
            btnPunto.Enabled = false;
            btnResultado.Enabled = false;
            btnPorcentaje.Enabled = false;
            btnMultiplicacion.Enabled = false;
            btnSuma.Enabled = false;
            btnResta.Enabled = false;
            btnDivision.Enabled = false;

            btnCuadrado.Enabled = false;
            btnCubico.Enabled = false;
            btnPotencia.Enabled = false;
            btnFactorial.Enabled = false;
            btnLog.Enabled = false;
            btnLn.Enabled = false;
            btnExp.Enabled = false;
            btnSin.Enabled = false;
            btnCos.Enabled = false;
            btnTan.Enabled = false;
            btnRaiz.Enabled = false;
            btnAbsoluto.Enabled = false;


        }

        public void Punto_No_Repeat()
        {
            btnPi.Enabled = false;
            btnPunto.Enabled = false;
            btnResultado.Enabled = false;
            btnPorcentaje.Enabled = false;
        }

        public void Reset_Calculadora()
        {
            btnPi.Enabled = true;
            btnUno.Enabled = true;
            btnDos.Enabled = true;
            btnTres.Enabled = true;
            btnCuatro.Enabled = true;
            btnCinco.Enabled = true;
            btnSeis.Enabled = true;
            btnSiete.Enabled = true;
            btnOcho.Enabled = true;
            btnNueve.Enabled = true;
            btnCero.Enabled = true;

            btnPunto.Enabled = false;

            btnMultiplicacion.Enabled = false;
            btnSuma.Enabled = false;
            btnResta.Enabled = false;
            btnDivision.Enabled = false;
            btnPorcentaje.Enabled = false;
            btnResultado.Enabled = false;

            btnLog.Enabled = true;
            btnLn.Enabled = true;
            btnExp.Enabled = true;
            btnSin.Enabled = true;
            btnCos.Enabled = true;
            btnTan.Enabled = true;
            btnRaiz.Enabled = true;
            btnAbsoluto.Enabled = true;

            btnCuadrado.Enabled = false;
            btnCubico.Enabled = false;
            btnPotencia.Enabled = false;
            btnFactorial.Enabled = false;

        }
        public void general_hab()
        {
            btnUno.Enabled = true;
            btnDos.Enabled = true;
            btnTres.Enabled = true;
            btnCuatro.Enabled = true;
            btnCinco.Enabled = true;
            btnSeis.Enabled = true;
            btnSiete.Enabled = true;
            btnOcho.Enabled = true;
            btnNueve.Enabled = true;
            btnCero.Enabled = true;
            btnPi.Enabled = true;

            btnPunto.Enabled = false;
            btnMultiplicacion.Enabled = false;
            btnDivision.Enabled = false;
            btnSuma.Enabled = false;
            btnResta.Enabled = false;
            btnPorcentaje.Enabled = false;
            btnResultado.Enabled = false;

            btnCuadrado.Enabled = false;
            btnCubico.Enabled = false;
            btnPotencia.Enabled = false;
            btnFactorial.Enabled = false;
            btnLog.Enabled = false;
            btnLn.Enabled = false;
            btnExp.Enabled = false;
            btnSin.Enabled = false;
            btnCos.Enabled = false;
            btnTan.Enabled = false;
            btnRaiz.Enabled = false;
            btnAbsoluto.Enabled = false;
        }
        public void Porcentaje_Hab()
        {
            btnUno.Enabled = true;
            btnDos.Enabled = true;
            btnTres.Enabled = true;
            btnCuatro.Enabled = true;
            btnCinco.Enabled = true;
            btnSeis.Enabled = true;
            btnSiete.Enabled = true;
            btnOcho.Enabled = true;
            btnNueve.Enabled = true;
            btnCero.Enabled = true;
            btnPi.Enabled = false;
            btnPunto.Enabled = true;

            btnResultado.Enabled = true;

            btnMultiplicacion.Enabled = false;
            btnDivision.Enabled = false;
            btnSuma.Enabled = false;
            btnResta.Enabled = false;
            btnPorcentaje.Enabled = false;

            btnCuadrado.Enabled = false;
            btnCubico.Enabled = false;
            btnPotencia.Enabled = false;
            btnFactorial.Enabled = false;
            btnLog.Enabled = false;
            btnLn.Enabled = false;
            btnExp.Enabled = false;
            btnSin.Enabled = false;
            btnCos.Enabled = false;
            btnTan.Enabled = false;
            btnRaiz.Enabled = false;
            btnAbsoluto.Enabled = false;
            btnFactorial.Enabled = false;
        }

        public void Porcentaje_Pi()
        {
            btnPi.Enabled = false;
            btnPunto.Enabled = false;
            btnUno.Enabled = false;
            btnDos.Enabled = false;
            btnTres.Enabled = false;
            btnCuatro.Enabled = false;
            btnCinco.Enabled = false;
            btnSeis.Enabled = false;
            btnSiete.Enabled = false;
            btnOcho.Enabled = false;
            btnNueve.Enabled = false;
            btnCero.Enabled = false;
            btnResultado.Enabled = true; 
        }
        private void Desabilitador_General()
        {
            btnPi.Enabled = false;
            btnPunto.Enabled = false;
            btnUno.Enabled = false;
            btnDos.Enabled = false;
            btnTres.Enabled = false;
            btnCuatro.Enabled = false;
            btnCinco.Enabled = false;
            btnSeis.Enabled = false;
            btnSiete.Enabled = false;
            btnOcho.Enabled = false;
            btnNueve.Enabled = false;
            btnCero.Enabled = false;
            btnResultado.Enabled = false;
            btnMultiplicacion.Enabled = false;
            btnDivision.Enabled = false;
            btnSuma.Enabled = false;
            btnResta.Enabled = false;
            btnPorcentaje.Enabled = false;
            btnCuadrado.Enabled = false;
            btnCubico.Enabled = false;
            btnPotencia.Enabled = false;
            btnFactorial.Enabled = false;
            btnLog.Enabled = false;
            btnLn.Enabled = false;
            btnExp.Enabled = false;
            btnSin.Enabled = false;
            btnCos.Enabled = false;
            btnTan.Enabled = false;
            btnRaiz.Enabled = false;
            btnAbsoluto.Enabled = false;
            btnFactorial.Enabled = false;
        }
        
    }
}