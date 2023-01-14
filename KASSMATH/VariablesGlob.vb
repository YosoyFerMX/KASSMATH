Module VariablesGlob
       Public respDeno As Integer
    Public respNum As Integer
    Public ProcesoNum1 As Integer
    Public ProcesoNum2 As Integer
    Public ProcesoNum3, RespNumerador, RespuestaDenominador, Num1Mixto, Num2Mixto, Num3Mixto As Integer
    Public mcm As Integer
    Public ResultadoNum As Integer
    Public Ent1, Ent2, Ent3, Den1, Den2, Den3, Num1, Num2, Num3 As Integer
    Public Hacer, nivel As Integer
    Public matriz1(10, 3) As String
    Public RespNumSimpli, ResDenSimpli As Integer
    Public entero, residuo, conversion, MismoDen As Integer
    Public comprobar, analizando As Integer
    Public RespMixtoEntrada As Double
    Public RespMixto As Double
    Public EntEntero, EntResiduoMix, EntDenoMix As Integer

    Public TamañoMatriz As Integer 'PARA CALCULAR EL TAMAÑO DE LA MATRIZ'
    Public resultado_string_suma_propias As String = ""

    Public resultado_string_suma_impropias As String = ""
    Public resultado_string_suma_mixtas As String = ""





'VARIABLE QUE ME SERVIRÁ PARA TRAJAR CON LAS PANTALLAS DEL EXAMEN

Public exa_si_no As Integer = 0 'VARIABLE PARA VALIDAR EN UNA CONDICIONAL Y SABER SI SE PRESIONO EL BOTON DE EXAMEN O NO

'VARIABLES PARA EL NUMERO DE RESPUESTAS Y MOSTRARLAS EN LA TABLA DE RESULTADOS
Public numero_correcta As Integer = 0
Public numero_incorrecta As Integer = 0

'VARIABLE PARA INDICAR CUANTAS VECES SE DEBE DE REPETIR LA PREGUNTA. EN ESTE CASO DEBEN DE SER 2, FUNCIONA COMO CONTADOR

Public contador_propia As Integer = 0
Public contador_impropia As Integer = 0





End Module
