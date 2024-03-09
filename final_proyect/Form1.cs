using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace final_proyect
{
    public partial class Form1 : Form
    {
        
        private void cboDatasheet_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ivWindow_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }


        double price = 0;
        string code;
        string features;    
        string case_type;
        public Form1()
        {

      
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            lblPrecio.Text = (0).ToString("C");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            this.lblFechaHora.Text = datetime.ToString();
        }

        private void cboComponents_SelectedIndexChanged(object sender, EventArgs e)
        {
            string product = cboComponents.Text;
          
            if (product.Equals("Amplificador OP07P")) 
            {
                price = 346;
                code = "OP07P";
                features = "Amplificador Operacional de ultra baja tensión de offset";
                case_type = "DIP-8";
            }

            if (product.Equals("Amplificador OP177GP"))
            {
                price = 445;
                code = "OP177GP";
                features = "Amplificador Operacional de ultra presición. Ultra baja tensión de offset";
                case_type = "DIP-8";
            }

            if (product.Equals("Amplificador TL061CP"))
            {
                price = 360;
                code = "TL061CP";
                features = "Amplificador Operacional entrada JFET de baja potencia";
                case_type = "DIP-8";
            }

            if (product.Equals("Amplificador TL062"))
            {
                price = 378;
                code = "TL062";
                features = "Amplificador Operacional entrada JFET de baja potencia";
                case_type = "DIP-8";
            }

            if (product.Equals("Amplificador TL071CP"))
            {
                price = 344;
                code = "TL071CP";
                features = "Amplificador Operacional de bajo ruido con entrada JFET";
                case_type = "DIP-8";
            }

            if (product.Equals("Amplificador TL072CP"))
            {
                price = 344;
                code = "TL071CP";
                features = "Amplificador Operacional de bajo ruido con entrada JFET";
                case_type = "DIP-8";
            }

            if (product.Equals("Amplificador TL074CN"))
            {
                price = 344;
                code = "TL074CN";
                features = "Amplificador Operacional de bajo ruido con entrada JFET.";
                case_type = "DIP-14";
            }

            if (product.Equals("Amplificador TL081CP"))
            {
                price = 654;
                code = "TL081CP";
                features = "Amplificador Operacional con entrada JFET";
                case_type = "DIP-8";
            }

            if (product.Equals("Amplificador TL082CP"))
            {
                price = 600;
                code = "TL082CP";
                features = "Amplificador Operacional dual con entrada JFET";
                case_type = "DIP-8";
            }

            if (product.Equals("Amplificador TL084CN"))
            {
                price = 700;
                code = "TL084CN";
                features = "Amplificador Operacional quad con entrada JFET";
                case_type = "DIP-14";
            }

            if (product.Equals("Amplificador LM324SMDR"))
            {
                price = 345;
                code = "LM324SMDR";
                features = "Amplificador operacional cuádruple de baja potencia";
                case_type = "SOIC-14";
            }

            if (product.Equals("Amplificador LM324N"))
            {
                price = 300;
                code = "LM324N";
                features = "Amplificador operacional cuádruple de baja potencia";
                case_type = "DIP-14";
            }

            if (product.Equals("Amplificador LM346N"))
            {
                price = 250;
                code = "LM346N";
                features = "Amplificador operacional quad programable";
                case_type = "DIP-16";
            }

            if (product.Equals("Amplificador LM348N"))
            {
                price = 500;
                code = "LM348N";
                features = "Cuádruple amplificador operacional - Características similares al 741";
                case_type = "DIP-14";
            }

            if (product.Equals("Amplificador LF353N"))
            {
                price = 550;
                code = "LF353N";
                features = "Amplificador operacional dual con entrada JFET y gran ancho de banda";
                case_type = "DIP-8";
            }

            if (product.Equals("Amplificador LF356N"))
            {
                price = 200;
                code = "LF356N";
                features = "Amplificador operacional con entrada JFET de alta tensión";
                case_type = "DIP-8";
            }

            if (product.Equals("Amplificador LM358N"))
            {
                price = 450;
                code = "LM358N";
                features = "Amplificador operacional dual de baja potencia";
                case_type = "DIP-8";
            }

            if (product.Equals("Amplificador LM386N"))
            {
                price = 350;
                code = "LM386N";
                features = "Amplificador de potencia de audio baja tensión";
                case_type = "DIP-8";
            }

            if (product.Equals("Amplificador LM741CN"))
            {
                price = 150;
                code = "LM741CN";
                features = "Amplificador operacional standard";
                case_type = "DIP-8";
            }

            if (product.Equals("Amplificador LM2904N"))
            {
                price = 89;
                code = "LM2904N";
                features = "Amplificador operacional dual de baja potencia";
                case_type = "DIP-8";
            }

            if (product.Equals("Amplificador LM3900N"))
            {
                price = 89;
                code = "LM3900N";
                features = "Amplificador operacional cuádruple Norton";
                case_type = "DIP-14";
            }

            if (product.Equals("Amplificador MC33202P"))
            {
                price = 190;
                code = "MC33202P";
                features = "Amplificador operacional dual baja tensión rail-to-rail";
                case_type = "DIP-9";
            }

            if (product.Equals("Amplificador RC4558"))
            {
                price = 150;
                code = "RC4558";
                features = "Amplificador operacional dual de alta ganancia.";
                case_type = "DIP-8";
            }

            if (product.Equals("Amplificador TDA2003"))
            {
                price = 200;
                code = "TDA2003";
                features = "Amplificador de audio 10W";
                case_type = "PENTAWATT ";
            }

            if (product.Equals("Comparador LM339N"))
            {
                price = 342;
                code = "LM339N";
                features = "Comparador quad de baja potencia y baja tensión de offset";
                case_type = "DIP-14";
            }

            if (product.Equals("Comparador LM393N"))
            {
                price = 200;
                code = "LM393N";
                features = "Comparador dual de bajo offset y baja potencia";
                case_type = "DIP-8 ";
            }

            if (product.Equals("Comparador LM2903"))
            {
                price = 150;
                code = "LM2903";
                features = "Comparador dual bajo offset y baja potencia";
                case_type = "DIP-8";
            }

            if (product.Equals("Comparador LM311N"))
            {
                price = 100;
                code = "LM311N";
                features = "Comparador de Tensión";
                case_type = "DIP-8";
            }

            if (product.Equals("Conversor DAC0800"))
            {
                price = 120;
                code = "DAC0800";
                features = "Conversor D/A de 8 bits ";
                case_type = "DIP-16";
            }

            if (product.Equals("Conversor DAC0808"))
            {
                price = 100;
                code = "DIP-16";
                features = "Conversor D/A de 8 bits";
                case_type = "DIP-16";
            }

            if (product.Equals("Conversor ADS1240E"))
            {
                price = 90;
                code = "ADS1240E";
                features = "Conversor A/D de 24 bits";
                case_type = "DIP-24";
            }

            if (product.Equals("Conversor CA3162"))
            {
                price = 150;
                code = "CA3162";
                features = "Conversor A/D para display de 3 dígitos ";
                case_type = "DIP-16";
            }

            if (product.Equals("Conversor ICL7107"))
            {
                price = 200;
                code = "ICL7107";
                features = "Conversor A/D para display LCD/LED de 3 1/2 dígitos";
                case_type = "DIP-40";
            }

            if (product.Equals("Conversor ICL7135"))
            {
                price = 120;
                code = "ICL7135";
                features = "Conversor A/D de 4 1/2 dígitos con salidas BCD multiplexadas";
                case_type = "DIP-28";
            }

            if (product.Equals("Regulador LM2940CT-5.0"))
            {
                price = 240;
                code = "LM2940CT-5.0";
                features = "Regulador de tensión LDO 1A Vsal: 5V";
                case_type = "TO-220";
            }

            if (product.Equals("Regulador LM2940T-9.0"))
            {
                price = 200;
                code = "LM2940T-9.0";
                features = "Regulador de tensión LDO 1A Vsal: 9V";
                case_type = "LLP-8";
            }

            if (product.Equals("Regulador LM2940CT-12"))
            {
                price = 140;
                code = "LM2940CT-12";
                features = "Regulador de tensión LDO 1A Vsal: 12V";
                case_type = "TO-220";
            }

            if (product.Equals("Regulador LM2575T-5.0"))
            {
                price = 300;
                code = "LM2575T-5.0";
                features = "Regulador de tensión Step-Down 1A Vsal: 5V";
                case_type = "TO-220";
            }

            if (product.Equals("Regulador LM2575S-5.0"))
            {
                price = 330;
                code = "LM2575S-5.0";
                features = "Regulador de tensión Step-Down 1A Vsal: 5V";
                case_type = "TO-263";
            }

            if (product.Equals("Regulador LM2575S-ADJ"))
            {
                price = 330;
                code = "LM2575S-ADJ";
                features = "Regulador de tensión Step-Down 1A Vsal: Ajustable";
                case_type = "TO-263";
            }

            if (product.Equals("Regulador LM2575T12"))
            {
                price = 270;
                code = "LM2575T12";
                features = "Regulador de tensión Step-Down 1A Vsal: 12V";
                case_type = "TO-220";
            }

            if (product.Equals("Regulador LM2576T-5"))
            {
                price = 150;
                code = "LM2576T-5";
                features = "Regulador de tensión Step-Down 3A Vsal: 5V";
                case_type = "TO-220";
            }

            if (product.Equals("Regulador LM2576S-5.0"))
            {
                price = 310;
                code = "LM2576S-5.0";
                features = "Regulador de tensión Step-Down 3A Vsal: 5V";
                case_type = "TO-263";
            }

            if (product.Equals("Regulador LM2576S-ADJ"))
            {
                price = 140;
                code = "LM2576S-ADJ";
                features = "Regulador de tensión Step-Down 3A Vsal: Ajustable";
                case_type = "TO-263";
            }

            if (product.Equals("Regulador LM2596S-3.3"))
            {
                price = 130;
                code = "LM2596S-3.3";
                features = "Regulador switching Step-Down 3A Vsal: 3,3V";
                case_type = "TO-263";
            }

            if (product.Equals("Regulador LM2596S-5.0"))
            {
                price = 100;
                code = "LM2596S-5.0";
                features = "Regulador switching Step-Down 3A Vsal: 5V";
                case_type = "TO-263";
            }

            if (product.Equals("Regulador LM2596S-ADJ"))
            {
                price = 100;
                code = "LM2596S-ADJ";
                features = "Regulador switching Step-Down 3A Vsal: Ajustable";
                case_type = "TO-263";
            }

            if (product.Equals("Regulador LM2577T-ADJ"))
            {
                price = 135;
                code = "LM2577T-ADJ";
                features = "Regulador de tensión Step-Up 3A, ajustable";
                case_type = "TO-263";
            }

            if (product.Equals("Regulador LM5008MM"))
            {
                price = 150;
                code = "LM5008MM";
                features = "Regulador switching Step Down High Voltage 100V";
                case_type = "Mini SOIC-8";
            }

            if (product.Equals("Regulador LM2621MM"))
            {
                price = 200;
                code = "LM2621MM";
                features = "Low Input Voltage, Step-Up DC-DC, ajustable";
                case_type = "Mini SOIC-8";
            }

            if (product.Equals("Regulador LM2588S-ADJ"))
            {
                price = 300;
                code = "LM2588S-ADJ";
                features = "Regulador Flyback con Shutdown 5A";
                case_type = "TO-263";
            }

            if (product.Equals("Regulador MC34166T"))
            {
                price = 300;
                code = "MC34166T";
                features = "Regulador switching de potencia -1.5V a +Vin 3A";
                case_type = "314D";
            }

            if (product.Equals("Regulador zener LM336Z2,5"))
            {
                price = 150;
                code = "LM336Z2,5";
                features = "Zener de referencia 2,5V";
                case_type = "TO-92";
            }

            if (product.Equals("Regulador zener LM336Z5"))
            {
                price = 180;
                code = "LM336Z5";
                features = "Zener de referencia 5V";
                case_type = "TO-92";
            }

            if (product.Equals("Regulador zener LM385Z1,2"))
            {
                price = 340;
                code = "LM385Z1,2 ";
                features = "Zener de referencia 1.2V";
                case_type = "TO-92";
            }

            if (product.Equals("Regulador zener LM385Z2,5"))
            {
                price = 340;
                code = "LM385Z2,5";
                features = "Zener de referencia 2.5V";
                case_type = "TO-92";
            }

            if (product.Equals("Regulador zener TL431C"))
            {
                price = 200;
                code = "TL431C";
                features = "Zener programable 2,5 a 36V";
                case_type = "TO-92";
            }

            if (product.Equals("Regulador TL494CN"))
            {
                price = 450;
                code = "TL494CN";
                features = "Circuito de control de modulación de ancho de pulso para switching";
                case_type = "DIP-16";
            }

            if (product.Equals("Regulador LM334"))
            {
                price = 180;
                code = "LM334";
                features = "Fuente regulable de corriente 3 terminales";
                case_type = "TO-92";
            }

            if (product.Equals("Regulador MC34063AP1"))
            {
                price = 230;
                code = "MC34063AP1";
                features = "Regulador switching para conversor DC-DC";
                case_type = "DIP-8 ";
            }

            if (product.Equals("Regulador SG3525AN"))
            {
                price = 250;
                code = "SG3525AN ";
                features = "Controlador para modulador de ancho de pulso. ";
                case_type = "DIP-16";
            }

            if (product.Equals("Regulador LM3524N"))
            {
                price = 250;
                code = "SG3525AN ";
                features = "Controlador para modulador de ancho de pulso. ";
                case_type = "DIP-16";
            }

            if (product.Equals("Compuerta logica 74HC00N"))
            {
                price = 300;
                code = "SG3525AN ";
                features = "Cuádruple NAND de 2 entradas";
                case_type = "DIP-14";
            }

            if (product.Equals("Compuerta logica 74HC02N"))
            {
                price = 200;
                code = "74HC02N ";
                features = "Cuádruple NOR de 2 entradas";
                case_type = "DIP-14";
            }

            if (product.Equals("Compuerta logica 74HC04N"))
            {
                price = 200;
                code = "74HC04N ";
                features = "Séxtuple inversor";
                case_type = "DIP-14";
            }

            if (product.Equals("Compuerta logica 74HC11N"))
            {
                price = 200;
                code = "74HC11N ";
                features = "Triple AND de 3 entradas";
                case_type = "DIP-14";
            }

            if (product.Equals("Compuerta logica 74HC14N"))
            {
                price = 200;
                code = "74HC14N ";
                features = "Séxtuple inversor Schmitt Trigger";
                case_type = "DIP-14";
            }

            if (product.Equals("Compuerta logica 74HC74N"))
            {
                price = 200;
                code = "74HC14N ";
                features = "Doble flip flop D con preset y clear";
                case_type = "DIP-14";
            }

            if (product.Equals("Compuerta logica 74HC132N"))
            {
                price = 160;
                code = "74HC132N ";
                features = "Cuádruple NAND Schmitt Trigger 2 entradas";
                case_type = "DIP-14";
            }

            if (product.Equals("Compuerta logica 74HC138N"))
            {
                price = 160;
                code = "74HC138N";
                features = "Decodificador de 3 a 8 vías";
                case_type = "DIP-16";
            }

            if (product.Equals("Compuerta logica 74HC164N"))
            {
                price = 250;
                code = "74HC164N";
                features = "Registro de desplaz. 8 bits ent. serie/sal. paralelo";
                case_type = "DIP-14";
            }

            if (product.Equals("Compuerta logica 74HC241N"))
            {
                price = 250;
                code = "74HC241N";
                features = "Ocho buffers no inversores salidas 3 estados";
                case_type = "DIP-20";
            }

            if (product.Equals("Compuerta logica 74HC244N"))
            {
                price = 250;
                code = "74HC241N";
                features = "Ocho buffers salidas 3 estados";
                case_type = "DIP-20";
            }

            if (product.Equals("Compuerta logica 74HC245N"))
            {
                price = 200;
                code = "74HC245N";
                features = "Ocho transceptores salidas 3 estados";
                case_type = "DIP-20";
            }

            if (product.Equals("Compuerta logica 74HC273N"))
            {
                price = 200;
                code = "74HC273N";
                features = "Ocho flip flops D con clear";
                case_type = "DIP-20";
            }

            if (product.Equals("Compuerta logica 74HC373N"))
            {
                price = 200;
                code = "74HC373N";
                features = "Ocho latch D salidas 3 estados";
                case_type = "DIP-20";
            }

            if (product.Equals("Compuerta logica 74HC374N"))
            {
                price = 200;
                code = "74HC374N";
                features = "Ocho flip flop D salidas 3 estados";
                case_type = "DIP-20";
            }

            if (product.Equals("Compuerta logica 74HC393N"))
            {
                price = 300;
                code = "74HC393N";
                features = "Doble contador binario de 4 bits";
                case_type = "DIP-14";
            }

            if (product.Equals("Compuerta logica 74HC393N"))
            {
                price = 300;
                code = "74HC393N";
                features = "Doble contador binario de 4 bits";
                case_type = "DIP-14";
            }

            if (product.Equals("Compuerta logica 74HC573N"))
            {
                price = 250;
                code = "74HC573N";
                features = "Doble contador binario de 4 bits";
                case_type = "DIP-20";
            }

            if (product.Equals("Compuerta logica 74HC574N"))
            {
                price = 250;
                code = "74HC574N";
                features = "Ocho flip flop D edge- triggered salidas 3 estados.";
                case_type = "DIP-20";
            }

            if (product.Equals("Compuerta logica 74HC595N"))
            {
                price = 290;
                code = "74HC595N";
                features = "Registro de desplazamiento de 8 bits con latchs de salida";
                case_type = "DIP-16";
            }

            if (product.Equals("Compuerta logica 74HC4040N"))
            {
                price = 220;
                code = "74HC4040N";
                features = "Contador binario de 12 bits de salida";
                case_type = "DIP-16";
            }

            if (product.Equals("Compuerta logica 74HC4078N"))
            {
                price = 220;
                code = "74HC4078N";
                features = "Compuerta NOR / OR de 8 entradas";
                case_type = "DIP-14";
            }

            if (product.Equals("Compuerta logica 74HC4094N"))
            {
                price = 220;
                code = "74HC4094N";
                features = "Registro de desplazamiento/almacenamiento de 8 bits";
                case_type = "DIP-16";
            }

            if (product.Equals("Compuerta logica 74HCT04"))
            {
                price = 200;
                code = "74HCT04";
                features = "Séxtuple inversor";
                case_type = "DIP-14";
            }

            if (product.Equals("Compuerta logica 74HCT138"))
            {
                price = 250;
                code = "74HCT138";
                features = "Decodificador de 3 a 8 vías";
                case_type = "DIP-16";
            }

            if (product.Equals("Compuerta logica 74HCT244"))
            {
                price = 270;
                code = "74HCT244";
                features = "Ocho buffers con salida de 3 estados";
                case_type = "DIP-20";
            }

            if (product.Equals("Compuerta logica 74HCT245"))
            {
                price = 270;
                code = "74HCT245";
                features = "Ocho bus transceiver con salida 3 estados";
                case_type = "DIP-20";
            }

            if (product.Equals("Compuerta logica 74HCT245"))
            {
                price = 190;
                code = "74HCT245";
                features = "Ocho flip flop D con salidas de 3 estados";
                case_type = "DIP-20";
            }

            if (product.Equals("Compuerta logica 74LS00"))
            {
                price = 150;
                code = "74LS00";
                features = "Cuádruple NAND de dos entradas";
                case_type = "DIP-14";
            }

            if (product.Equals("Compuerta logica 74LS02"))
            {
                price = 200;
                code = "74LS02";
                features = "Cuádruple NOR de dos entradas";
                case_type = "DIP-14";
            }

            if (product.Equals("Compuerta logica 74LS03"))
            {
                price = 200;
                code = "74LS03";
                features = "Cuádruple NAND de dos entr. con salidas open collector";
                case_type = "DIP-14";
            }

            if (product.Equals("Compuerta logica 74LS04"))
            {
                price = 350;
                code = "74LS04";
                features = "Séxtuple inversor";
                case_type = "DIP-14";
            }

            if (product.Equals("Compuerta logica 74LS08"))
            {
                price = 300;
                code = "74LS08";
                features = "Cuádruple AND con dos entradas.";
                case_type = "DIP-14";
            }

            if (product.Equals("Compuerta logica 74LS09"))
            {
                price = 280;
                code = "74LS09";
                features = "Cuádruple AND con dos entradas y salidas open collector";
                case_type = "DIP-14";
            }

            if (product.Equals("Compuerta logica 74LS32"))
            {
                price = 340;
                code = "74LS32";
                features = "Cuádruple OR de dos entradas";
                case_type = "DIP-14";
            }

            if (product.Equals("Compuerta logica 74LS47"))
            {
                price = 340;
                code = "74LS47";
                features = "Driver/Decodificador BCD a 7 segmentos";
                case_type = "DIP-16";
            }

            if (product.Equals("Compuerta logica 74LS112"))
            {
                price = 200;
                code = "74LS112";
                features = "Doble flip-flop JK";
                case_type = "DIP-16";
            }

            if (product.Equals("Compuerta logica 74LS138"))
            {
                price = 200;
                code = "74LS138";
                features = "Decodificador/Demultiplexor 3 a 8 vías";
                case_type = "DIP-16";
            }

            if (product.Equals("Compuerta logica 74LS139"))
            {
                price = 200;
                code = "74LS139";
                features = "Doble Decodificador/Demultiplexor de 1 a 4";
                case_type = "DIP-16";
            }

            if (product.Equals("Compuerta logica 74LS164"))
            {
                price = 220;
                code = "74LS164";
                features = "Registro de desplazamiento 8 bits. Entr. serie, sal. paralelo";
                case_type = "DIP-14";
            }

            if (product.Equals("Compuerta logica 74LS240"))
            {
                price = 220;
                code = "74LS240";
                features = "Ocho inversores con salidas de 3 estados";
                case_type = "DIP-20";
            }

            if (product.Equals("Compuerta logica 74LS240"))
            {
                price = 220;
                code = "74LS240";
                features = "Ocho inversores con salidas de 3 estados";
                case_type = "DIP-20";
            }

            if (product.Equals("Compuerta logica 74LS244"))
            {
                price = 220;
                code = "74LS244";
                features = "Ocho bus driver con salidas de 3 estados";
                case_type = "DIP-20";
            }

            if (product.Equals("Compuerta logica 74LS245"))
            {
                price = 220;
                code = "74LS245";
                features = "Ocho bus transceiver";
                case_type = "DIP-20";
            }

            if (product.Equals("Compuerta logica 74LS273"))
            {
                price = 220;
                code = "74LS273";
                features = "Ocho flip-flop D.";
                case_type = "DIP-20";
            }

            if (product.Equals("Compuerta logica 74LS373"))
            {
                price = 190;
                code = "74LS373";
                features = "Ocho latches D transparente con sal. 3 estados";
                case_type = "DIP-20";
            }

            if (product.Equals("Compuerta logica 74LS374"))
            {
                price = 390;
                code = "74LS374";
                features = "Ocho latches D edge triggered con sal. 3 estados";
                case_type = "DIP-20";
            }

            if (product.Equals("Compuerta logica 74LS541"))
            {
                price = 390;
                code = "74LS541";
                features = "Ocho buffers/line drivers con salidas de 3 estados";
                case_type = "DIP-20";
            }

            if (product.Equals("Compuerta logica 74LS541"))
            {
                price = 390;
                code = "74LS541";
                features = "Ocho buffers/line drivers con salidas de 3 estados";
                case_type = "DIP-20";
            }

            if (product.Equals("Compuerta logica CD4001"))
            {
                price = 360;
                code = "CD4001";
                features = "Cuádruple compuerta NOR de 2 entradas";
                case_type = "DIP-14";
            }

            if (product.Equals("Compuerta logica CD4011"))
            {
                price = 250;
                code = "CD4011";
                features = "Cuádruple compuerta NAND de 2 entradas";
                case_type = "DIP-14";
            }

            if (product.Equals("Compuerta logica CD4013"))
            {
                price = 290;
                code = "CD4013";
                features = "Doble flip flop D";
                case_type = "DIP-14";
            }

            if (product.Equals("Compuerta logica CD4014"))
            {
                price = 280;
                code = "CD4014";
                features = "Registro de desplazamiento de 8 bits";
                case_type = "DIP-16";
            }

            if (product.Equals("Compuerta logica CD4016"))
            {
                price = 280;
                code = "CD4016";
                features = "Cuádruple switch bilatera";
                case_type = "DIP-14";
            }

            if (product.Equals("Compuerta logica CD4017"))
            {
                price = 280;
                code = "CD4017";
                features = "Contador/divisor por décadas con 10 salidas decodificadas";
                case_type = "DIP-16";
            }

            if (product.Equals("Compuerta logica CD4020"))
            {
                price = 280;
                code = "CD4020";
                features = "Contador binario 14-bits";
                case_type = "DIP-16";
            }

            if (product.Equals("Compuerta logica CD4021"))
            {
                price = 280;
                code = "CD4021";
                features = "Registro de desplazamiento de 8 bits";
                case_type = "DIP-16";
            }

            if (product.Equals("Compuerta logica CD4024"))
            {
                price = 280;
                code = "CD4024";
                features = "Contador binario de 7 salidas con carry";
                case_type = "DIP-14";
            }

            if (product.Equals("Compuerta logica CD4027"))
            {
                price = 280;
                code = "CD4027";
                features = "Doble JK master/reset con set y reset";
                case_type = "DIP-16";
            }

            if (product.Equals("Compuerta logica CD4028"))
            {
                price = 400;
                code = "CD4028";
                features = "Decodificador BCD/decimal";
                case_type = "DIP-16";
            }

            if (product.Equals("Compuerta logica CD4029"))
            {
                price = 380;
                code = "CD4029";
                features = "Contador programable binario/décadas up/down";
                case_type = "DIP-16";
            }

            if (product.Equals("Compuerta logica CD4040"))
            {
                price = 330;
                code = "CD4040";
                features = "Contador binario de 12 bits";
                case_type = "DIP-16";
            }

            if (product.Equals("Compuerta logica CD4042"))
            {
                price = 300;
                code = "CD4042";
                features = "Cuádruple latch D sincrónico";
                case_type = "DIP-16";
            }

            if (product.Equals("Compuerta logica CD4049"))
            {
                price = 240;
                code = "CD4049";
                features = "Séxtuple buffers inversores";
                case_type = "DIP-16";
            }

            if (product.Equals("Compuerta logica CD4050"))
            {
                price = 240;
                code = "CD4050";
                features = "Séxtuple buffers no inversores";
                case_type = "DIP-16";
            }

            if (product.Equals("Compuerta logica CD4051"))
            {
                price = 250;
                code = "CD4051";
                features = "MUX/DEMUX 8 vías analógicas";
                case_type = "DIP-16";
            }

            if (product.Equals("Compuerta logica CD4052"))
            {
                price = 250;
                code = "CD4052";
                features = "Doble MUX/DEMUX analógico de 4 vías";
                case_type = "DIP-16";
            }

            if (product.Equals("Compuerta logica CD4053"))
            {
                price = 550;
                code = "CD4053";
                features = "Triple MUX/DEMUX analógico de 2 vías";
                case_type = "DIP-16";
            }

            if (product.Equals("Compuerta logica CD4060"))
            {
                price = 200;
                code = "CD4060";
                features = "Contador binario de 14 bits y buffer oscilador";
                case_type = "DIP-16";
            }

            if (product.Equals("Compuerta logica CD4066"))
            {
                price = 300;
                code = "CD4066";
                features = "Cuádruple switch bilateral";
                case_type = "DIP-14";
            }

            if (product.Equals("Compuerta logica CD4068"))
            {
                price = 200;
                code = "CD4068";
                features = "Compuerta NAND de 8 entradas";
                case_type = "DIP-14";
            }

            if (product.Equals("Compuerta logica CD4069"))
            {
                price = 300;
                code = "CD4069";
                features = "Circuito de 6 inversores";
                case_type = "DIP-14";
            }

            if (product.Equals("Compuerta logica CD4070"))
            {
                price = 300;
                code = "CD4070";
                features = "Cuádruple OR-EXCLUSIVE de 2 entradas";
                case_type = "DIP-14";
            }

            if (product.Equals("Compuerta logica CD4071"))
            {
                price = 290;
                code = "CD4071";
                features = "Cuádruple compuerta OR de 2 entradas";
                case_type = "DIP-14";
            }

            if (product.Equals("Compuerta logica CD4081"))
            {
                price = 190;
                code = "CD4081";
                features = "Cuádruple compuerta AND de 2 entradas";
                case_type = "DIP-14";
            }

            if (product.Equals("Compuerta logica CD4093"))
            {
                price = 390;
                code = "CD4093";
                features = "Cuádruple NAND de 2 entradas Schmitt Trigger";
                case_type = "DIP-14";
            }

            if (product.Equals("Compuerta logica CD40106"))
            {
                price = 390;
                code = "CD40106";
                features = "Hex Schmitt Trigger.";
                case_type = "DIP-14";
            }

            if (product.Equals("Compuerta logica CD4511"))
            {
                price = 240;
                code = "CD4511";
                features = "Latch/decodificador/driver BCD a siete segmentos";
                case_type = "DIP-16";
            }

            if (product.Equals("Compuerta logica CD4511"))
            {
                price = 240;
                code = "CD4511";
                features = "Latch/decodificador/driver BCD a siete segmentos";
                case_type = "DIP-16";
            }

            if (product.Equals("Compuerta logica CD4512"))
            {
                price = 240;
                code = "CD4512";
                features = "Selector de datos de 8 canales";
                case_type = "DIP-16";
            }

            if (product.Equals("Compuerta logica CD4514"))
            {
                price = 230;
                code = "CD4514";
                features = "Latch transparente de 4 btis/Decodif. de 4 a 16 (sal. alta)";
                case_type = "DIP-24";
            }

            if (product.Equals("Compuerta logica CD4520"))
            {
                price = 230;
                code = "CD4520";
                features = "Doble contador binario up";
                case_type = "DIP-16";
            }

            if (product.Equals("Compuerta logica CD4527"))
            {
                price = 300;
                code = "CD4527";
                features = "Multiplicador BCD";
                case_type = "DIP-16";
            }

            if (product.Equals("Compuerta logica CD4528"))
            {
                price = 190;
                code = "CD4528";
                features = "Doble multivibrador monoastable";
                case_type = "DIP-16";
            }

            if (product.Equals("Compuerta logica CD4538"))
            {
                price = 200;
                code = "CD4538";
                features = "Doble multivibrador monoastablede precisión trigger/reset";
                case_type = "DIP-16";
            }

            if (product.Equals("Compuerta logica CD4541"))
            {
                price = 200;
                code = "CD4541";
                features = "Timer programable";
                case_type = "DIP-16";
            }

            if (product.Equals("Compuerta logica CD4543"))
            {
                price = 300;
                code = "CD4543";
                features = "Latch/decodif./driver BCD a siete seg. para cristal líquido";
                case_type = "DIP-16";
            }

            if (product.Equals("Infrarrojo IRM8601S"))
            {
                price = 39;
                code = "IRM8601S";
                features = "Módulo receptor, Fo: 38KHz, θh: 45°, θv: 35°, λp: 940nm ";
                case_type = "Ninguno";
            }

            if (product.Equals("Infrarrojo TSOP4838"))
            {
                price = 25;
                code = "IRM8601S";
                features = "Módulo receptor, Fo: 38KHz, _1/2: 45º, _: 950nm";
                case_type = "Ninguno";
            }

            if (product.Equals("Infrarrojo TSOP1156"))
            {
                price = 30;
                code = "TSOP1156";
                features = "Módulo receptor, Fo: 56KHz, θ1/2: 45°, λp: 940nm";
                case_type = "Ninguno";
            }

            if (product.Equals("Infrarrojo L34F3BT"))
            {
                price = 29;
                code = "L34F3BT";
                features = "Emisor, diám.: 3mm, 2θ1/2: 50°, λp: 940nm";
                case_type = "Ninguno";
            }

            if (product.Equals("Infrarrojo IR908-7C"))
            {
                price = 25;
                code = "IR908-7C";
                features = "Emisor, 2θ1/2: 60°, λp: 940nm";
                case_type = "Ninguno";
            }

            if (product.Equals("Infrarrojo IR908-7C/F2"))
            {
                price = 20;
                code = "IR908-7C/F2 ";
                features = "Emisor, 2θ1/2: ±30°, λp: 940nm";
                case_type = "Ninguno";
            }

            if (product.Equals("Infrarrojo TSUS5402"))
            {
                price = 25;
                code = "TSUS5402";
                features = "Emisor, diám.: 5mm, 2θ1/2: ±22°, λp: 950nm ";
                case_type = "Ninguno";
            }

            if (product.Equals("Infrarrojo IR333"))
            {
                price = 3;
                code = "IR333";
                features = "Emisor, diám.: 5mm, 2θ1/2: 20°, λp: 940nm";
                case_type = "Ninguno";
            }

            if (product.Equals("Infrarrojo IR383"))
            {
                price = 5;
                code = "IR383";
                features = "Emisor, diám.: 5mm, 2θ1/2: 20°, λp: 940nm";
                case_type = "Ninguno";
            }

            if (product.Equals("Fototransistor PT202C"))
            {
                price = 15;
                code = "PT202C";
                features = "NPN. Water clear, diám.: 3mm, IC(ON): 2mA, λp: 860nm";
                case_type = "Ninguno";
            }

            if (product.Equals("Fototransistor BPW85A"))
            {
                price = 12;
                code = "BPW85A";
                features = "NPN. Water clear, diám.: 3mm, ICA: 1,5mA, λp: 850nm, ϕ: ±25° ";
                case_type = "Ninguno";
            }

            if (product.Equals("Fototransistor PT334-6C"))
            {
                price = 18;
                code = "PT334-6C";
                features = "NPN. Water clear, diám.: 5mm, Ic(ON): 3mA";
                case_type = "Ninguno";
            }

            if (product.Equals("Fototransistor PT908-7C"))
            {
                price = 10;
                code = "PT908-7C";
                features = "NPN. Water clear, 4,5 x 5,7 x 1,5 mm, IC(ON): 3,12mA, 2θ1/2: 60°";
                case_type = "Ninguno";
            }

            if (product.Equals("Fototransistor L32P3C"))
            {
                price = 25;
                code = "L32P3C";
                features = "NPN. Diám.: 3mm, IC(ON): 0,5mA";
                case_type = "Ninguno";
            }

            if (product.Equals("Fototransistor L51P3C"))
            {
                price = 20;
                code = "L51P3C";
                features = "NPN. Water clear, diám.: 5mm, IC(ON): 0,5mA";
                case_type = "Ninguno";
            }

            if (product.Equals("Fotodiodo BPV10"))
            {
                price = 19;
                code = "BPV10";
                features = "Silicon PIN. Diám.: 5mm, Iro: 1nA, λp: 920nm, ϕ: ±20°";
                case_type = "Ninguno";
            }

            if (product.Equals("Fotodiodo BP104"))
            {
                price = 25;
                code = "BP104";
                features = "Silicon PIN. Iro: 2nA, λp: 950nm, ϕ: ±65°";
                case_type = "Ninguno";
            }

            if (product.Equals("Fotodiodo BP104"))
            {
                price = 25;
                code = "BP104";
                features = "Silicon PIN. Iro: 2nA, λp: 950nm, ϕ: ±65°";
                case_type = "Ninguno";
            }

            if (product.Equals("Optoacoplador K814P"))
            {
                price = 20;
                code = "K814P";
                features = "Tipo: salida transistor | Vr (V): 7 | If (mA): 60 | CTR (%):  >20%";
                case_type = "4-PIN";
            }

            if (product.Equals("Optoacoplador CNY17-1"))
            {
                price = 22;
                code = "CNY17-1";
                features = "Tipo: salida transistor | Vr (V): 6 | If (mA): 90 | CTR (%): 40 a 80%";
                case_type = "6-PIN";
            }

            if (product.Equals("Optoacoplador CNY17-003"))
            {
                price = 25;
                code = "CNY17-003";
                features = "Tipo: salida transistor | Vr (V): 6 | If (mA): 90 | CTR (%): 100 a 200%";
                case_type = "6-PIN";
            }

            if (product.Equals("Optoacoplador 4N25"))
            {
                price = 18;
                code = "4N25";
                features = "Tipo: salida transistor | Vr (V): 6 | If (mA): 100 | CTR (%): >20%";
                case_type = "6-PIN";
            }

            if (product.Equals("Optoacoplador 4N26"))
            {
                price = 18;
                code = "4N26";
                features = "Tipo: salida transistor | Vr (V): 6 | If (mA): 100 | CTR (%): >20%";
                case_type = "6-PIN";
            }

            if (product.Equals("Optoacoplador 4N28"))
            {
                price = 15;
                code = "4N28";
                features = "Tipo: salida transistor | Vr (V): 6 | If (mA): 100 | CTR (%): >10%";
                case_type = "6-PIN";
            }

            if (product.Equals("Optoacoplador 4N32"))
            {
                price = 25;
                code = "4N32";
                features = "Tipo: Salida Darlington | Vr (V): 3 | If (mA): 80 | CTR (%): 500%";
                case_type = "6-PIN";
            }

            if (product.Equals("Optoacoplador 4N33"))
            {
                price = 20;
                code = "4N33";
                features = "Tipo: Salida Darlington | Vr (V): 3 | If (mA): 80 | CTR (%): 500%";
                case_type = "6-PIN";
            }

            if (product.Equals("Optoacoplador 4N35"))
            {
                price = 20;
                code = "4N35";
                features = "Tipo: Salida transistor | Vr (V): 6 | If (mA): 100 | CTR (%): >100%";
                case_type = "6-PIN";
            }

            if (product.Equals("Optoacoplador 6N135"))
            {
                price = 28;
                code = "6N135";
                features = "Tipo: Salida transistor. Alta velocidad | Vr (V): 5 | If (mA): 25 | CTR (%): 18%";
                case_type = "8-PIN";
            }

            if (product.Equals("Optoacoplador 6N137"))
            {
                price = 25;
                code = "6N137";
                features = "Tipo: Salida lógica. Alta velocidad. 1 canal  | Vr (V): 5 | If (mA): 50";
                case_type = "8-PIN";
            }

            if (product.Equals("Optoacoplador MOC3021"))
            {
                price = 20;
                code = "MOC3021";
                features = "Tipo: Salida triac | Vr (V): 3 | If (mA): 60";
                case_type = "6-PIN";
            }

            if (product.Equals("Optoacoplador MOC3041"))
            {
                price = 19;
                code = "MOC3041";
                features = "Tipo: Salida triac. Cruce x cero | Vr (V): 6 | If (mA): 60";
                case_type = "6-PIN";
            }

            if (product.Equals("Optoacoplador TCRT1000"))
            {
                price = 19;
                code = "TCRT1000";
                features = "Tipo: Reflectivo con salida transistor | Vr (V): 5 | If (mA): 50 | CTR (%): 2,50%";
                case_type = "-";
            }

            if (product.Equals("Optoacoplador CNY74-2"))
            {
                price = 19;
                code = "MOC3041";
                features = "Tipo: 2 canales con salida transistor | Vr (V): 5 | If (mA): 50 | CTR (%): 50 a 600%";
                case_type = "8-PIN";
            }

            if (product.Equals("Optoacoplador CNY74-4"))
            {
                price = 19;
                code = "CNY74-4";
                features = "Tipo: 4 canales con salida transistor | Vr (V): 6 | If (mA): 60 | CTR (%): 50 a 600%";
                case_type = "16-PIN";
            }

            if (product.Equals("Capacitores Cerámicos CERXX"))
            {
                price = 19;
                code = "CERXX";
                features = "Rango de Capacidad: (Clase 1 = 1,0 pF - 680 pF), (Clase 2 = 100pF - 100.000pF)| Tensiones (VCC): 50, 100";
                case_type = "Material ceramico";
            }

            if (product.Equals("Capacitores Cerámicos (SMD) C0805"))
            {
                price = 11;
                code = "C0805";
                features = "Rango de Capacidad: (NP0 = 1pf - 10pF), (X7R = 100pf - 0.1mF), (Y5V = 10nF - 220nF) | Tensiones (VCC): 50";
                case_type = "SMD";
            }

            if (product.Equals("Capacitores Cerámicos (SMD) C1206"))
            {
                price = 11;
                code = "C1206";
                features = "Rango de Capacidad: (NP0 = 1pf - 5.6pF), (X7R = 220pf - 100nF), (Y5V = 10nF - 470nF) | Tensiones (VCC): 50";
                case_type = "SMD";
            }

            if (product.Equals("Capacitor Multicapa MULZ5UM"))
            {
                price = 5;
                code = "MULZ5UM";
                features = "Rango de Capacidad segun dielectrico / tensiones: (X&R = 2,2nF - 0,1uF), (Z5U = 1pF - 1uF)";
                case_type = "normal";
            }

            if (product.Equals("Capacitor Multicapa MULX7R"))
            {
                price = 5;
                code = "MULX7R";
                features = "Rango de Capacidad segun dielectrico / tensiones: XTR = (50V), X7R = (50V)";
                case_type = "normal";
            }

            if (product.Equals("Capacitores Tantalio"))
            {
                price = 100;
                code = "TANXX";
                features = "Rango de Capacidad: 0.1uF - 100uF | Tensiones (VCC): 16, 25, 35, 50";
                case_type = "Material de tantalio";
            }

            if (product.Equals("Capacitores Poliéster"))
            {
                price = 20;
                code = "POLXX";
                features = "Rango de Capacidad: 0,001 uF - 1 uF | Tensiones (VCC): 100, 250, 400, 630";
                case_type = "Material de poliester";
            }

            if (product.Equals("Capacitores Electrolíticos 105°C"))
            {
                price = 15;
                code = "ELEXX";
                features = "Rango de Capacidad: 0,47 - 10000 uF | Tensiones (VCC): 6,3 - 400";
                case_type = "Normal";
            }

            if (product.Equals("Capacitores Blindados"))
            {
                price = 1500;
                code = "BLIXX";
                features = "Rango de Capacidad: 47 - 47000 uF | Tensiones (VCC): 25 - 450 | Temperatura: 85°C";
                case_type = "Normal";
            }

            if (product.Equals("Led 3mm 1254GD"))
            {
                price = 5;
                code = "1254GD";
                features = "Tipo: Alta Eficiencia | Color: Verde | If (mA): 30| Vf (V): 2.1 | Intensidad (mCd): 16";
                case_type = "Normal";
            }

            if (product.Equals("Led 3mm 204HGW"))
            {
                price = 5;
                code = "204HGW";
                features = "Tipo: Bicolor | Color: Rojo / Verde | If (mA): - | Vf (V): 2 | Intensidad (mCd): -";
                case_type = "Normal";
            }

            if (product.Equals("Led 3mm 204YD"))
            {
                price = 5;
                code = "204YD";
                features = "Tipo: Difuso | Color: Amarillo | If (mA): 25 | Vf (V): 2 | Intensidad (mCd): 4.5";
                case_type = "Normal";
            }


            if (product.Equals("Led 3mm 204HD"))
            {
                price = 5;
                code = "204HD";
                features = "Tipo: Difuso | Color: Verde | If (mA): 15 | Vf (V): 2 | Intensidad (mCd): 1";
                case_type = "Normal";
            }

            if (product.Equals("Led 3mm 204GD"))
            {
                price = 5;
                code = "204GD";
                features = "Tipo: Difuso | Color: Verde | If (mA): 30| Vf (V): 2.1 | Intensidad (mCd): 10";
                case_type = "Normal";
            }

            if (product.Equals("Led 3mm 1254ID"))
            {
                price = 5;
                code = "1254ID";
                features = "Tipo: Alta Eficiencia | Color: Rojo | If (mA): 30| Vf (V): 2 | Intensidad (mCd): 25";
                case_type = "Normal";
            }

            if (product.Equals("Led 5mm 336EGW"))
            {
                price = 5;
                code = "336EGW";
                features = "Tipo: Bicolor | Color: Naranja/Verde | If (mA): 30| Vf (V): 2 | Intensidad (mCd): 2.5";
                case_type = "Normal";
            }

            if (product.Equals("Led 5mm 1383GD"))
            {
                price = 5;
                code = "1383GD";
                features = "Tipo: Alta Eficiencia | Color: Verde | If (mA): 30| Vf (V): 2.1 | Intensidad (mCd): 40";
                case_type = "Normal";
            }

            if (product.Equals("Led 5mm 1383YD"))
            {
                price = 5;
                code = "1383YD";
                features = "Tipo: Alta Eficiencia | Color: Amarillo | If (mA): 25| Vf (V): 2| Intensidad (mCd): 1";
                case_type = "Normal";
            }

            if (product.Equals("Led 5mm 1383ID"))
            {
                price = 5;
                code = "1383ID";
                features = "Tipo: Alta Eficiencia | Color: Rojo | If (mA): 30 | Vf (V): 2 | Intensidad (mCd): 40";
                case_type = "Normal";
            }

            if (product.Equals("Led 5mm 333GD"))
            {
                price = 5;
                code = "333GD";
                features = "Tipo: Alta Eficiencia | Color: Verde | If (mA): 30 | Vf (V): 2.1 | Intensidad (mCd): 10";
                case_type = "Normal";
            }

            if (product.Equals("Led 5mm 333ID"))
            {
                price = 5;
                code = "333ID";
                features = "Tipo: Alta Eficiencia | Color: Rojo | If (mA): 30 | Vf (V): 2 | Intensidad (mCd): 10";
                case_type = "Normal";
            }

            if (product.Equals("Led 5mm 333ID/TRI"))
            {
                price = 5;
                code = "1383ID";
                features = "Tipo: Alta Eficiencia | Color: Rojo | If (mA): 30 | Vf (V): 2 | Intensidad (mCd): 10";
                case_type = "Normal";
            }

            if (product.Equals("Led 5mm 333YD"))
            {
                price = 5;
                code = "333YD";
                features = "Tipo: Alta Eficiencia | Color: Amarillo | If (mA): 25 | Vf (V): 2 | Intensidad (mCd): 10";
                case_type = "Normal";
            }

            if (product.Equals("Led 5mm 333HD"))
            {
                price = 5;
                code = "333HD";
                features = "Tipo: Difuso | Color: Rojo | If (mA): 15 | Vf (V): 2.1 | Intensidad (mCd): 2";
                case_type = "Normal";
            }

            if (product.Equals("Led 5mm 333HRC-6"))
            {
                price = 5;
                code = "333HRC-6";
                features = "Tipo: Water Clear | Color: Rojo | If (mA): 20 | Vf (V): 1.7 | Intensidad (mCd): 600";
                case_type = "Normal";
            }

            if (product.Equals("Led 5mm 383VYC"))
            {
                price = 5;
                code = "383VYC";
                features = "Tipo: Water Clear | Color: Amarillo | If (mA): 30 | Vf (V): 2 | Intensidad (mCd): 250";
                case_type = "Normal";
            }

            if (product.Equals("Led 5mm 383UGC"))
            {
                price = 5;
                code = "383UGC ";
                features = "Tipo: Water Clear | Color: Verde | If (mA): 30 | Vf (V): 2.1 | Intensidad (mCd): 700";
                case_type = "Normal";
            }

            if (product.Equals("Led 5mm 383UBC/H2"))
            {
                price = 5;
                code = "383UBC/H2 ";
                features = "Tipo: Water Clear | Color: Azul | If (mA): 30 | Vf (V): 3.8 | Intensidad (mCd): 630";
                case_type = "Normal";
            }

            if (product.Equals("Led 5mm 339EVGW"))
            {
                price = 5;
                code = "339EVGW";
                features = "Tipo: Bicolor/C.C | Color: Rojo/Verde | If (mA): 20 | Vf (V): 2.4 | Intensidad (mCd): 10";
                case_type = "Normal";
            }

            if (product.Equals("Led 8mm L793YD"))
            {
                price = 5;
                code = "L793YD";
                features = "Tipo: Difuso | Color: Amarillo | If (mA): 20 | Vf (V): 2.1 | Intensidad (mCd): 50";
                case_type = "Normal";
            }

            if (product.Equals("Led 10mm 363VGD"))
            {
                price = 5;
                code = "363VGD";
                features = "Tipo: Alta eficiencia | Color: Verde | If (mA): 30 | Vf (V): 2 | Intensidad (mCd): 40";
                case_type = "Normal";
            }

            if (product.Equals("Led 10mm 363VYD"))
            {
                price = 5;
                code = "363VYD";
                features = "Tipo: Alta eficiencia | Color: Amarillo | If (mA): 30 | Vf (V): 2 | Intensidad (mCd): 40";
                case_type = "Normal";
            }

            if (product.Equals("Led 10mm 363VRD"))
            {
                price = 5;
                code = "363VRD";
                features = "Tipo: Alta eficiencia | Color: Rojo | If (mA): 30 | Vf (V): 2 | Intensidad (mCd): 40";
                case_type = "Normal";
            }


            lblPrecio.Text = price.ToString("C");

        }

        private void btnGetDatasheet_Click(object sender, EventArgs e)
        {
            string datasheet = cboDatasheet.Text;
            if (datasheet.Equals("Amplificador OP07P"))
            {
                Process.Start("https://pdf1.alldatasheet.com/datasheet-pdf/view/547874/AD/OP07.html");
            }


            if (datasheet.Equals("Amplificador OP177GP"))
            {
                Process.Start("https://pdf1.alldatasheet.com/datasheet-pdf/view/174961/AD/OP177GP.html");
            }

            if (datasheet.Equals("Amplificador TL061CP"))
            {
                Process.Start("https://pdf1.alldatasheet.com/datasheet-pdf/view/177125/TI/TL061CP.html");
            }

            if (datasheet.Equals("Amplificador TL062"))
            {
                Process.Start("https://pdf1.alldatasheet.com/datasheet-pdf/view/28774/TI/TL062.html");
            }


            if (datasheet.Equals("Amplificador TL071CP"))
            {
                Process.Start("https://pdf1.alldatasheet.com/datasheet-pdf/view/28804/TI/TL071CP.html");
            }


            if (datasheet.Equals("Amplificador TL072CP"))
            {
                Process.Start("https://pdf1.alldatasheet.com/datasheet-pdf/view/206611/TI/TL072CP.html");
            }

            if (datasheet.Equals("Amplificador TL074CN"))
            {
                Process.Start("https://pdf1.alldatasheet.com/datasheet-pdf/view/12681/ONSEMI/TL074CN.html");
            }

            if (datasheet.Equals("Amplificador TL081CP"))
            {
                Process.Start("https://pdf1.alldatasheet.com/datasheet-pdf/view/28808/TI/TL081CP.html");
            }

            if (datasheet.Equals("Amplificador TL082CP"))
            {
                Process.Start("https://pdf1.alldatasheet.com/datasheet-pdf/view/25407/STMICROELECTRONICS/TL082CP.html");
            }


            if (datasheet.Equals("Amplificador TL084CN"))
            {
                Process.Start("https://pdf1.alldatasheet.com/datasheet-pdf/view/12682/ONSEMI/TL084CN.html");
            }


            if (datasheet.Equals("Amplificador LM324SMDR"))
            {
                Process.Start("https://pdf1.alldatasheet.com/datasheet-pdf/view/780627/ONSEMI/LM324S.html");
            }


            if (datasheet.Equals("Amplificador LM324N"))
            {
                Process.Start("https://pdf1.alldatasheet.com/datasheet-pdf/view/17880/PHILIPS/LM324N.html");
            }

            if (datasheet.Equals("Amplificador LM346N"))
            {
                Process.Start("https://pdf1.alldatasheet.com/datasheet-pdf/view/22762/STMICROELECTRONICS/LM346N.html");
            }

            if (datasheet.Equals("Amplificador LM348N"))
            {
                Process.Start("https://pdf1.alldatasheet.com/datasheet-pdf/view/53583/FAIRCHILD/LM348N.html");
            }


            if (datasheet.Equals("Amplificador LF353N"))
            {
                Process.Start("https://pdf1.alldatasheet.com/datasheet-pdf/view/53570/FAIRCHILD/LF353N.html");
            }


            if (datasheet.Equals("Amplificador LF356N"))
            {
                Process.Start("https://pdf1.alldatasheet.com/datasheet-pdf/view/551680/TI/LF356N.html");
            }


            if (datasheet.Equals("Amplificador LM358N"))
            {
                Process.Start("https://pdf1.alldatasheet.com/datasheet-pdf/view/3073/MOTOROLA/LM358N.html");
            }

            if (datasheet.Equals("Amplificador LM386N"))
            {
                Process.Start("https://pdf1.alldatasheet.com/datasheet-pdf/view/447323/TGS/LM386N.html");
            }

            if (datasheet.Equals("Amplificador LM741CN"))
            {
                Process.Start("https://pdf1.alldatasheet.com/datasheet-pdf/view/53590/FAIRCHILD/LM741CN.html");
            }


            if (datasheet.Equals("Amplificador LM2904N"))
            {
                Process.Start("https://pdf1.alldatasheet.com/datasheet-pdf/view/3075/MOTOROLA/LM2904N.html");
            }


            if (datasheet.Equals("Amplificador LM3900N"))
            {
                Process.Start("https://pdf1.alldatasheet.com/datasheet-pdf/view/126359/MOTOROLA/LM3900N.html");
            }

            if (datasheet.Equals("Amplificador MC33202P"))
            {
                Process.Start("https://pdf1.alldatasheet.com/datasheet-pdf/view/174281/ONSEMI/MC33202P.html");
            }

            if (datasheet.Equals("Amplificador RC4558"))
            {
                Process.Start("https://pdf1.alldatasheet.com/datasheet-pdf/view/54399/FAIRCHILD/RC4558.html");
            }

            if (datasheet.Equals("Amplificador TDA2003"))
            {
                Process.Start("https://pdf1.alldatasheet.com/datasheet-pdf/view/161245/YOUDA/TDA2003.html");
            }


            if (datasheet.Equals("Amplificador LM339N"))
            {
                Process.Start("https://pdf1.alldatasheet.com/datasheet-pdf/view/545685/TI/LM339N.html");
            }


            if (datasheet.Equals("Amplificador LM393N"))
            {
                Process.Start("https://pdf1.alldatasheet.com/datasheet-pdf/view/53574/FAIRCHILD/LM393N.html");
            }

            if (datasheet.Equals("Amplificador LM2903"))
            {
                Process.Start("https://pdf1.alldatasheet.com/datasheet-pdf/view/17874/PHILIPS/LM2903.html");
            }

            if (datasheet.Equals("Amplificador LM311N"))
            {
                Process.Start("https://pdf1.alldatasheet.com/datasheet-pdf/view/17875/PHILIPS/LM311N.html");
            }

        }


        private void btnLeave_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            if (cboComponents.SelectedIndex == -1)
                MessageBox.Show("You must choose a product...!!!");
            else if (txtAmount.Text == "")
                MessageBox.Show("You must enter an amount...!!!");
            else if (cboType.SelectedIndex == -1)
                MessageBox.Show("You must choose a type...!!!");

            else
            {
                string product = cboComponents.Text;
                int amount = Convert.ToInt32(txtAmount.Text);
                string gift = cboGift.Text;
                string type = cboType.Text;


                double tax = 1.08;
                double subtotal = amount * price;
                double sub_tax = subtotal * tax;
                double discount = 0;
                double total_price = 0;

                if (gift.Equals("0% Gift card"))
                {
                    total_price = subtotal * tax;
                }

                if (gift.Equals("10% Gift card"))
                {                    
                    discount = 0.1 * sub_tax;
                    total_price = sub_tax - discount;
                }

                if (gift.Equals("20% Gift card"))
                {
                    discount = 0.2 * sub_tax;
                    total_price = sub_tax - discount;
                }

                if (gift.Equals("30% Gift card"))
                {
                    discount = 0.3 * sub_tax;
                    total_price = sub_tax - discount;
                }

                if (gift.Equals("40% Gift card"))
                {
                    discount = 0.4 * sub_tax;
                    total_price = sub_tax - discount;
                }

                if (gift.Equals("50% Gift card"))
                {
                    discount = 0.5 * sub_tax;
                    total_price = sub_tax - discount;
                }

                if (gift.Equals("60% Gift card"))
                {
                    discount = 0.6 * sub_tax;
                    total_price = sub_tax - discount;
                }

                if (gift.Equals("70% Gift card"))
                {
                    discount = 0.7 * sub_tax;
                    total_price = sub_tax - discount;
                }

                if (gift.Equals("80% Gift card"))
                {
                    discount = 0.8 * sub_tax;
                    total_price = sub_tax - discount;
                }


                ListViewItem file = new ListViewItem(product);
                file.SubItems.Add(code.ToString());
                file.SubItems.Add(features.ToString());
                file.SubItems.Add(case_type.ToString());
                file.SubItems.Add(amount.ToString());
                file.SubItems.Add(price.ToString());
                file.SubItems.Add(type.ToString());
                file.SubItems.Add(subtotal.ToString());
                file.SubItems.Add(sub_tax.ToString());
                file.SubItems.Add(discount.ToString());
                file.SubItems.Add(total_price.ToString());

                ivWindow.Items.Add(file);

            }
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.alldatasheet.com/");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.allelectronics.com/pdf-catalog");
        }

        private void btnCancelx_Click(object sender, EventArgs e)
        {
            ivWindow.Items.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Sure?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                ivWindow.Items.RemoveAt(ivWindow.SelectedIndices[0]);                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            MessageBox.Show(columnHeader6.DisplayIndex.ToString());
        }
    }
 
}

