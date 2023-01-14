Module variables_globales

'PROPIAS_RESULTADOS
Public num_resul_divi_propia As Integer
Public den_resul_divi_propia As Integer

Public resultado_string_propias As String = ""
Public resultado_string_impropias As String = ""
Public resultado_string_mixtas As String

'IMPROPIAS_RESULTADOS
Public num_resul_divi_impropia As Integer
Public den_resul_divi_impropia As Integer




Public numero_tipo As Integer
'Arreglo para fracciones de 2 digitos
Public digitos_global_2digitos(7) As Integer
'Arreglo para fracciones de 3 digitos
Public digitos_global_3digitos(9) As Integer

'ARREGLO PARA MIXTAS
Public digitos_global_mixtas(12) As Integer


Public arreglo_comun_multiplo(100) As Integer

'VARIALE PARA SABER CUAL FORM ABRIR, YA SEA NIVEL 1 Y 2 O NIVEL 2 Y 4
Public nivel_regresar As Integer = 0


'OBTENER LA DIRECCION QUE SERVIRA PARA LA RUTA DEL VIDEO
    Public direccion As String = Application.ExecutablePath
    Public direccion_1 As String = InStr(direccion, "bin\Debug", CompareMethod.Text)



End Module
