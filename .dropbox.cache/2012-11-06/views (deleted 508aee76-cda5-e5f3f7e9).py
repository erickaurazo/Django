# Create your views here.
# -*- coding: utf-8 -*-
import ho.pisa as pisa
import cStringIO as StringIO
import cgi
from django.template import RequestContext
from django.template.loader import render_to_string
from django.http import HttpResponse
from hidrologia.models import *
from django.shortcuts import get_object_or_404

def number_format(self, num, decimal = 0):
    """
    Funcion que retorna un numero en el formato de tu configuracion
    Tiene que recibir:
        num = numero
        decimal = numero de decimales
    """
    locale.setlocale(locale.LC_ALL, "")
    return locale.format("%.*f", (decimal,int(num)),True)

def generar_pdf(html):
    # Función para generar el archivo PDF y devolverlo mediante HttpResponse
    result = StringIO.StringIO()
    pdf = pisa.pisaDocument(StringIO.StringIO(html.encode("UTF-8")), result)
    if not pdf.err:
        return HttpResponse(result.getvalue(), mimetype='application/pdf')
    return HttpResponse('Error al generar el PDF: %s' % cgi.escape(html))

def reporte_radiograma_presidente_pdf(request):
       # vista de ejemplo con un hipotético modelo Libro
    pagesize = "A4"
    radiograma=get_object_or_404(Radiograma, id=6)   
    radiograma_anterior = radiograma.obtener_radiograma_anterior()
     
    medida_chancay_anterior = Medida.objects.get(parametro=1,radiograma=radiograma_anterior.id)
    medida_compuerta_anterior = Medida.objects.get(parametro=2,radiograma=radiograma_anterior.id)
    medida_alimentador_anterior = Medida.objects.get(parametro=3,radiograma=radiograma_anterior.id)
    medida_aporte_anterior = Medida.objects.get(parametro=4,radiograma=radiograma_anterior.id)
    medida_descarga_anterior = Medida.objects.get(parametro=5,radiograma=radiograma_anterior.id)
    medida_majin_anterior = Medida.objects.get(parametro=6,radiograma=radiograma_anterior.id)
    medida_upch_anterior = Medida.objects.get(parametro=7,radiograma=radiograma_anterior.id)
    medida_circulante_anterior = Medida.objects.get(parametro=8,radiograma=radiograma_anterior.id)
    medida_puntilla_anterior = Medida.objects.get(parametro=9,radiograma=radiograma_anterior.id)
    medida_exceso_anterior = Medida.objects.get(parametro=10,radiograma=radiograma_anterior.id)
    medida_q_anterior = Medida.objects.get(parametro=11,radiograma=radiograma_anterior.id)
    medida_hm_anterior = Medida.objects.get(parametro=12,radiograma=radiograma_anterior.id)


    medida_chancay = Medida.objects.get(parametro=1,radiograma=radiograma.id)
    medida_compuerta = Medida.objects.get(parametro=2,radiograma=radiograma.id)
    medida_alimentador = Medida.objects.get(parametro=3,radiograma=radiograma.id)
    medida_aporte = Medida.objects.get(parametro=4,radiograma=radiograma.id)
    medida_descarga = Medida.objects.get(parametro=5,radiograma=radiograma.id)
    medida_majin = Medida.objects.get(parametro=6,radiograma=radiograma.id)
    medida_upch = Medida.objects.get(parametro=7,radiograma=radiograma.id)
    medida_circulante = Medida.objects.get(parametro=8,radiograma=radiograma.id)
    medida_puntilla = Medida.objects.get(parametro=9,radiograma=radiograma.id)
    medida_exceso = Medida.objects.get(parametro=10,radiograma=radiograma.id)
    medida_q = Medida.objects.get(parametro=11,radiograma=radiograma.id)
    medida_hm = Medida.objects.get(parametro=12,radiograma=radiograma.id)


    
    promedio_chancay_hora_12 = "%.03f " % medida_chancay_anterior.obtener_promedio_12_horas()
    promedio_chancay_hora_18 = "%.03f " % medida_chancay_anterior.obtener_promedio_18_horas()
    promedio_chancay_hora_24 = "%.03f " % medida_chancay_anterior.obtener_promedio_18_horas()
    promedio_Chancay = "%.03f " % medida_chancay_anterior.obtener_promedio_del_dia()
    promedio_chancay_hora_06 = "%.03f " % medida_chancay.obtener_promedio_06_horas()
    medida_chancay_hora_08 = "%.03f " % medida_chancay.hora8


    promedio_compuerta_hora_12 = "%.03f " % medida_compuerta_anterior.obtener_promedio_12_horas()
    promedio_compuerta_hora_18 = "%.03f " % medida_compuerta_anterior.obtener_promedio_18_horas()
    promedio_compuerta_hora_24 = "%.03f " % medida_compuerta_anterior.obtener_promedio_18_horas()
    promedio_compuerta = "%.03f " % medida_compuerta.obtener_promedio_del_dia()
    promedio_compuerta_hora_06 = "%.03f " % medida_compuerta.obtener_promedio_06_horas()
    medida_compuerta_hora_08 = "%.03f " % medida_compuerta.hora8


    promedio_alimentador_hora_12 =  "%.03f " % medida_alimentador_anterior.obtener_promedio_12_horas()
    promedio_alimentador_hora_18 =  "%.03f " % medida_alimentador_anterior.obtener_promedio_18_horas()
    promedio_alimentador_hora_24 =  "%.03f " % medida_alimentador_anterior.obtener_promedio_18_horas()
    promedio_alimentador =  "%.03f " % medida_alimentador_anterior.obtener_promedio_del_dia()
    promedio_alimentador_hora_06 =  "%.03f " % medida_alimentador.obtener_promedio_06_horas()
    medida_alimentador_hora_08 =  "%.03f " % medida_alimentador.hora8



    promedio_aporte_hora_12 =  "%.03f " %  medida_aporte_anterior.obtener_promedio_12_horas()
    promedio_aporte_hora_18 =  "%.03f " %  medida_aporte_anterior.obtener_promedio_18_horas()
    promedio_aporte_hora_24 = "%.03f "  %  medida_aporte_anterior.obtener_promedio_18_horas()
    promedio_aporte =  "%.03f " %  medida_aporte_anterior.obtener_promedio_del_dia()
    promedio_aporte_hora_06 =  "%.03f " %  medida_aporte.obtener_promedio_06_horas()
    medida_aporte_hora_08 =  "%.03f " %  medida_aporte.hora8




    promedio_descarga_hora_12 = "%.03f "  %  medida_descarga_anterior.obtener_promedio_12_horas()
    promedio_descarga_hora_18 =  "%.03f "  % medida_descarga_anterior.obtener_promedio_18_horas()
    promedio_descarga_hora_24 =  "%.03f " %  medida_descarga_anterior.obtener_promedio_18_horas()
    promedio_descarga =  "%.03f "  % medida_descarga_anterior.obtener_promedio_del_dia()
    promedio_descarga_hora_06 =  "%.03f " %  medida_descarga.obtener_promedio_06_horas()
    medida_descarga_hora_08 = "%.03f " % medida_descarga.hora8


    promedio_majin_hora_12 = "%.03f " %  medida_majin_anterior.obtener_promedio_12_horas()
    promedio_majin_hora_18 = "%.03f " %  medida_majin_anterior.obtener_promedio_18_horas()
    promedio_majin_hora_24 = "%.03f " %  medida_majin_anterior.obtener_promedio_18_horas()
    promedio_majin = "%.03f " %  medida_majin_anterior.obtener_promedio_del_dia()
    promedio_majin_hora_06 = "%.03f " %  medida_majin.obtener_promedio_06_horas()
    medida_majin_hora_08 = "%.03f " %   medida_majin.hora8



    promedio_upch_hora_12 = "%.03f " %  medida_upch_anterior.obtener_promedio_12_horas()
    promedio_upch_hora_18 = "%.03f " %  medida_upch_anterior.obtener_promedio_18_horas()
    promedio_upch_hora_24 ="%.03f " %   medida_upch_anterior.obtener_promedio_18_horas()
    promedio_upch = "%.03f " %  medida_upch_anterior.obtener_promedio_del_dia()
    promedio_upch_hora_06 = "%.03f " %  medida_upch.obtener_promedio_06_horas()
    medida_upch_hora_08 = "%.03f " %  medida_upch.hora8


    promedio_circulante_hora_12 = "%.03f " %  medida_circulante_anterior.obtener_promedio_12_horas()
    promedio_circulante_hora_18 = "%.03f "  % medida_circulante_anterior.obtener_promedio_18_horas()
    promedio_circulante_hora_24 = "%.03f " %  medida_circulante_anterior.obtener_promedio_18_horas()
    promedio_circulante =  "%.03f "  % medida_circulante_anterior.obtener_promedio_del_dia()
    promedio_circulante_hora_06 =  "%.03f " %  medida_circulante.obtener_promedio_06_horas()
    medida_circulante_hora_08 = "%.03f "  %  medida_circulante.hora8


    promedio_puntilla_hora_12 =  "%.03f "  % medida_puntilla_anterior.obtener_promedio_12_horas()
    promedio_puntilla_hora_18 =  "%.03f "  % medida_puntilla_anterior.obtener_promedio_18_horas()
    promedio_puntilla_hora_24 =  "%.03f " %  medida_puntilla_anterior.obtener_promedio_18_horas()
    promedio_puntilla =  "%.03f " %  medida_puntilla_anterior.obtener_promedio_del_dia()
    promedio_puntilla_hora_06 =  "%.03f " %  medida_puntilla.obtener_promedio_06_horas()
    medida_puntilla_hora_08 =  "%.03f " %  medida_puntilla.hora8


    promedio_exceso_hora_12 = "%.03f " %  medida_exceso_anterior.obtener_promedio_12_horas()
    promedio_exceso_hora_18 = "%.03f " %  medida_exceso_anterior.obtener_promedio_18_horas()
    promedio_exceso_hora_24 = "%.03f " %  medida_exceso_anterior.obtener_promedio_18_horas()
    promedio_exceso = "%.03f " %  medida_exceso_anterior.obtener_promedio_del_dia()
    promedio_exceso_hora_06 = "%.03f " %  medida_exceso.obtener_promedio_06_horas()
    medida_exceso_hora_08 = "%.03f " %  medida_exceso.hora8



    promedio_q_hora_12 = "%.03f " %  medida_q_anterior.obtener_promedio_12_horas()
    promedio_q_hora_18 = "%.03f " %  medida_q_anterior.obtener_promedio_18_horas()
    promedio_q_hora_24 = "%.03f " %  medida_q_anterior.obtener_promedio_18_horas()
    promedio_q = "%.03f " %  medida_q_anterior.obtener_promedio_del_dia()
    promedio_q_hora_06 = "%.03f " %  medida_q.obtener_promedio_06_horas()
    medida_q_hora_08 = "%.03f " %  medida_q.hora8


    promedio_hm_hora_12 = "%.03f " %  medida_hm_anterior.obtener_promedio_12_horas()
    promedio_hm_hora_18 = "%.03f " %  medida_hm_anterior.obtener_promedio_18_horas()
    promedio_hm_hora_24 = "%.03f " %  medida_hm_anterior.obtener_promedio_18_horas()
    promedio_hm = "%.03f " %  medida_hm_anterior.obtener_promedio_del_dia()
    promedio_hm_hora_06 = "%.03f " %  medida_hm.obtener_promedio_06_horas()
    medida_hm_hora_08 = "%.03f " %  medida_hm.hora8



    reservorio_cota =  "%.03f " %  radiograma.reservorio_cota
    reservorio_volumen =  "{:,}".format(radiograma.obtener_volumen())
    reservorio_perdidas = "{:,}".format(radiograma.obtener_perdidas())
    reservorio_evaporacion = "%.02f " % radiograma.reservorio_evaporacion
    reservorio_temperatura_maxima = "%.02f " % radiograma.reservorio_temperatura_maxima
    reservorio_temperatura_minima = "%.02f " % radiograma.reservorio_temperatura_minima
    reservorio_humedad_relativa = "%.02f " % radiograma.reservorio_humedad_relativa
    reservorio_precipitacion = "%.02f " % radiograma.reservorio_precipitacion
    reservorio_hora_precipitacion = radiograma.reservorio_hora_precipitacion
    max_chancay = "%.03f " % medida_chancay_anterior.obtener_maxima()
    min_chancay = "%.03f " % medida_chancay_anterior.obtener_minima()
    max_chancay_hora =  medida_chancay_anterior.obtener_hora_maxima()
    min_chancay_hora =  medida_chancay_anterior.obtener_hora_minima()


    trasvase_tunel_chonchano = "%.03f " % radiograma.trasvase_tunel_chonchano
    chonchano_seis_horas = "%.03f " % radiograma.chonchano_seishoras
    chotano_estado_tiempo = radiograma.chotano_estado_tiempo
    trasvase_tunel_chotano = "%.03f " % radiograma.trasvase_tunel_chotano
    chotano_seis_horas = "%.03f " % radiograma.chotano_seishoras
    chotano_humedad_relativa = "%.02f " % radiograma.chotano_humedad_relativa
    chotano_temperatura_maxima = "%.02f " % radiograma.chotano_temperatura_maxima
    chotano_temperatura_mimino = "%.02f " % radiograma.chotano_temperatura_mimino
    chotano_precipitacion =  "%.02f " % radiograma.chotano_precipitacion
    chotano_precipitacion_hora = radiograma.chotano_precipitacion_hora

    observacion = radiograma.observacion
    numero_radiograma = radiograma.numero
    fecha = radiograma.fecha

    html = render_to_string('reporte_diario_radiograma.presidente.html', locals(), context_instance=RequestContext(request))
    return generar_pdf(html)


def medidas_pdf(request):
    # vista de ejemplo con un hipotético modelo Libro
    pagesize = "A4"
    radiograma=get_object_or_404(Radiograma, id=32)   
     
    medida_chancay = Medida.objects.get(parametro=1,radiograma=radiograma.id)
    medida_compuerta = Medida.objects.get(parametro=2,radiograma=radiograma.id)
    medida_alimentador = Medida.objects.get(parametro=3,radiograma=radiograma.id)
    medida_aporte = Medida.objects.get(parametro=4,radiograma=radiograma.id)
    medida_descarga = Medida.objects.get(parametro=5,radiograma=radiograma.id)
    medida_majin = Medida.objects.get(parametro=6,radiograma=radiograma.id)
    medida_upch = Medida.objects.get(parametro=7,radiograma=radiograma.id)
    medida_circulante = Medida.objects.get(parametro=8,radiograma=radiograma.id)
    medida_puntilla = Medida.objects.get(parametro=9,radiograma=radiograma.id)
    medida_exceso = Medida.objects.get(parametro=10,radiograma=radiograma.id)
    medida_q = Medida.objects.get(parametro=11,radiograma=radiograma.id)
    medida_hm = Medida.objects.get(parametro=12,radiograma=radiograma.id)


    #Chancay
    medida_chancay_hora_01=  "%.03f " % medida_chancay.hora1
    medida_chancay_hora_02=  "%.03f " % medida_chancay.hora2
    medida_chancay_hora_03=  "%.03f " % medida_chancay.hora3
    medida_chancay_hora_04=  "%.03f " % medida_chancay.hora4
    medida_chancay_hora_05=  "%.03f " % medida_chancay.hora5
    medida_chancay_hora_06=  "%.03f " % medida_chancay.hora6
    medida_chancay_hora_07=  "%.03f " % medida_chancay.hora7
    medida_chancay_hora_08=  "%.03f " % medida_chancay.hora8
    medida_chancay_hora_09=  "%.03f " % medida_chancay.hora9
    medida_chancay_hora_10=  "%.03f " % medida_chancay.hora10
    medida_chancay_hora_11=  "%.03f " % medida_chancay.hora11
    medida_chancay_hora_12=  "%.03f " % medida_chancay.hora12
    medida_chancay_hora_13=  "%.03f " % medida_chancay.hora13
    medida_chancay_hora_14=  "%.03f " % medida_chancay.hora14
    medida_chancay_hora_15=  "%.03f " % medida_chancay.hora15
    medida_chancay_hora_16=  "%.03f " % medida_chancay.hora16
    medida_chancay_hora_17=  "%.03f " % medida_chancay.hora17
    medida_chancay_hora_18=  "%.03f " % medida_chancay.hora18
    medida_chancay_hora_19=  "%.03f " % medida_chancay.hora19
    medida_chancay_hora_20=  "%.03f " % medida_chancay.hora20
    medida_chancay_hora_21=  "%.03f " % medida_chancay.hora21
    medida_chancay_hora_22=  "%.03f " % medida_chancay.hora22
    medida_chancay_hora_23=  "%.03f " % medida_chancay.hora23
    medida_chancay_hora_24=  "%.03f " % medida_chancay.hora24

    #compuerta del rio
    medida_compuerta_hora_01=  "%.03f " % medida_compuerta.hora1
    medida_compuerta_hora_02=  "%.03f " % medida_compuerta.hora2
    medida_compuerta_hora_03=  "%.03f " % medida_compuerta.hora3
    medida_compuerta_hora_04=  "%.03f " % medida_compuerta.hora4
    medida_compuerta_hora_05=  "%.03f " % medida_compuerta.hora5
    medida_compuerta_hora_06=  "%.03f " % medida_compuerta.hora6
    medida_compuerta_hora_07=  "%.03f " % medida_compuerta.hora7
    medida_compuerta_hora_08=  "%.03f " % medida_compuerta.hora8
    medida_compuerta_hora_09=  "%.03f " % medida_compuerta.hora9
    medida_compuerta_hora_10=  "%.03f " % medida_compuerta.hora10
    medida_compuerta_hora_11=  "%.03f " % medida_compuerta.hora11
    medida_compuerta_hora_12=  "%.03f " % medida_compuerta.hora12
    medida_compuerta_hora_13=  "%.03f " % medida_compuerta.hora13
    medida_compuerta_hora_14=  "%.03f " % medida_compuerta.hora14
    medida_compuerta_hora_15=  "%.03f " % medida_compuerta.hora15
    medida_compuerta_hora_16=  "%.03f " % medida_compuerta.hora16
    medida_compuerta_hora_17=  "%.03f " % medida_compuerta.hora17
    medida_compuerta_hora_18=  "%.03f " % medida_compuerta.hora18
    medida_compuerta_hora_19=  "%.03f " % medida_compuerta.hora19
    medida_compuerta_hora_20=  "%.03f " % medida_compuerta.hora20
    medida_compuerta_hora_21=  "%.03f " % medida_compuerta.hora21
    medida_compuerta_hora_22=  "%.03f " % medida_compuerta.hora22
    medida_compuerta_hora_23=  "%.03f " % medida_compuerta.hora23
    medida_compuerta_hora_24=  "%.03f " % medida_compuerta.hora24

    #compuerta del rio
    medida_alimentador_hora_01=  "%.03f " % medida_alimentador.hora1
    medida_alimentador_hora_02=  "%.03f " % medida_alimentador.hora2
    medida_alimentador_hora_03=  "%.03f " % medida_alimentador.hora3
    medida_alimentador_hora_04=  "%.03f " % medida_alimentador.hora4
    medida_alimentador_hora_05=  "%.03f " % medida_alimentador.hora5
    medida_alimentador_hora_06=  "%.03f " % medida_alimentador.hora6
    medida_alimentador_hora_07=  "%.03f " % medida_alimentador.hora7
    medida_alimentador_hora_08=  "%.03f " % medida_alimentador.hora8
    medida_alimentador_hora_09=  "%.03f " % medida_alimentador.hora9
    medida_alimentador_hora_10=  "%.03f " % medida_alimentador.hora10
    medida_alimentador_hora_11=  "%.03f " % medida_alimentador.hora11
    medida_alimentador_hora_12=  "%.03f " % medida_alimentador.hora12
    medida_alimentador_hora_13=  "%.03f " % medida_alimentador.hora13
    medida_alimentador_hora_14=  "%.03f " % medida_alimentador.hora14
    medida_alimentador_hora_15=  "%.03f " % medida_alimentador.hora15
    medida_alimentador_hora_16=  "%.03f " % medida_alimentador.hora16
    medida_alimentador_hora_17=  "%.03f " % medida_alimentador.hora17
    medida_alimentador_hora_18=  "%.03f " % medida_alimentador.hora18
    medida_alimentador_hora_19=  "%.03f " % medida_alimentador.hora19
    medida_alimentador_hora_20=  "%.03f " % medida_alimentador.hora20
    medida_alimentador_hora_21=  "%.03f " % medida_alimentador.hora21
    medida_alimentador_hora_22=  "%.03f " % medida_alimentador.hora22
    medida_alimentador_hora_23=  "%.03f " % medida_alimentador.hora23
    medida_alimentador_hora_24=  "%.03f " % medida_alimentador.hora24

    #aporte
    medida_aporte_hora_01=  "%.03f " % medida_aporte.hora1
    medida_aporte_hora_02=  "%.03f " % medida_aporte.hora2
    medida_aporte_hora_03=  "%.03f " % medida_aporte.hora3
    medida_aporte_hora_04=  "%.03f " % medida_aporte.hora4
    medida_aporte_hora_05=  "%.03f " % medida_aporte.hora5
    medida_aporte_hora_06=  "%.03f " % medida_aporte.hora6
    medida_aporte_hora_07=  "%.03f " % medida_aporte.hora7
    medida_aporte_hora_08=  "%.03f " % medida_aporte.hora8
    medida_aporte_hora_09=  "%.03f " % medida_aporte.hora9
    medida_aporte_hora_10=  "%.03f " % medida_aporte.hora10
    medida_aporte_hora_11=  "%.03f " % medida_aporte.hora11
    medida_aporte_hora_12=  "%.03f " % medida_aporte.hora12
    medida_aporte_hora_13=  "%.03f " % medida_aporte.hora13
    medida_aporte_hora_14=  "%.03f " % medida_aporte.hora14
    medida_aporte_hora_15=  "%.03f " % medida_aporte.hora15
    medida_aporte_hora_16=  "%.03f " % medida_aporte.hora16
    medida_aporte_hora_17=  "%.03f " % medida_aporte.hora17
    medida_aporte_hora_18=  "%.03f " % medida_aporte.hora18
    medida_aporte_hora_19=  "%.03f " % medida_aporte.hora19
    medida_aporte_hora_20=  "%.03f " % medida_aporte.hora20
    medida_aporte_hora_21=  "%.03f " % medida_aporte.hora21
    medida_aporte_hora_22=  "%.03f " % medida_aporte.hora22
    medida_aporte_hora_23=  "%.03f " % medida_aporte.hora23
    medida_aporte_hora_24=  "%.03f " % medida_aporte.hora24


    #descarga
    medida_descarga_hora_01=  "%.03f " % medida_descarga.hora1
    medida_descarga_hora_02=  "%.03f " % medida_descarga.hora2
    medida_descarga_hora_03=  "%.03f " % medida_descarga.hora3
    medida_descarga_hora_04=  "%.03f " % medida_descarga.hora4
    medida_descarga_hora_05=  "%.03f " % medida_descarga.hora5
    medida_descarga_hora_06=  "%.03f " % medida_descarga.hora6
    medida_descarga_hora_07=  "%.03f " % medida_descarga.hora7
    medida_descarga_hora_08=  "%.03f " % medida_descarga.hora8
    medida_descarga_hora_09=  "%.03f " % medida_descarga.hora9
    medida_descarga_hora_10=  "%.03f " % medida_descarga.hora10
    medida_descarga_hora_11=  "%.03f " % medida_descarga.hora11
    medida_descarga_hora_12=  "%.03f " % medida_descarga.hora12
    medida_descarga_hora_13=  "%.03f " % medida_descarga.hora13
    medida_descarga_hora_14=  "%.03f " % medida_descarga.hora14
    medida_descarga_hora_15=  "%.03f " % medida_descarga.hora15
    medida_descarga_hora_16=  "%.03f " % medida_descarga.hora16
    medida_descarga_hora_17=  "%.03f " % medida_descarga.hora17
    medida_descarga_hora_18=  "%.03f " % medida_descarga.hora18
    medida_descarga_hora_19=  "%.03f " % medida_descarga.hora19
    medida_descarga_hora_20=  "%.03f " % medida_descarga.hora20
    medida_descarga_hora_21=  "%.03f " % medida_descarga.hora21
    medida_descarga_hora_22=  "%.03f " % medida_descarga.hora22
    medida_descarga_hora_23=  "%.03f " % medida_descarga.hora23
    medida_descarga_hora_24=  "%.03f " % medida_descarga.hora24


    #majin
    medida_majin_hora_01=  "%.03f " % medida_majin.hora1
    medida_majin_hora_02=  "%.03f " % medida_majin.hora2
    medida_majin_hora_03=  "%.03f " % medida_majin.hora3
    medida_majin_hora_04=  "%.03f " % medida_majin.hora4
    medida_majin_hora_05=  "%.03f " % medida_majin.hora5
    medida_majin_hora_06=  "%.03f " % medida_majin.hora6
    medida_majin_hora_07=  "%.03f " % medida_majin.hora7
    medida_majin_hora_08=  "%.03f " % medida_majin.hora8
    medida_majin_hora_09=  "%.03f " % medida_majin.hora9
    medida_majin_hora_10=  "%.03f " % medida_majin.hora10
    medida_majin_hora_11=  "%.03f " % medida_majin.hora11
    medida_majin_hora_12=  "%.03f " % medida_majin.hora12
    medida_majin_hora_13=  "%.03f " % medida_majin.hora13
    medida_majin_hora_14=  "%.03f " % medida_majin.hora14
    medida_majin_hora_15=  "%.03f " % medida_majin.hora15
    medida_majin_hora_16=  "%.03f " % medida_majin.hora16
    medida_majin_hora_17=  "%.03f " % medida_majin.hora17
    medida_majin_hora_18=  "%.03f " % medida_majin.hora18
    medida_majin_hora_19=  "%.03f " % medida_majin.hora19
    medida_majin_hora_20=  "%.03f " % medida_majin.hora20
    medida_majin_hora_21=  "%.03f " % medida_majin.hora21
    medida_majin_hora_22=  "%.03f " % medida_majin.hora22
    medida_majin_hora_23=  "%.03f " % medida_majin.hora23
    medida_majin_hora_24=  "%.03f " % medida_majin.hora24



    #upch
    medida_upch_hora_01=  "%.03f " % medida_upch.hora1
    medida_upch_hora_02=  "%.03f " % medida_upch.hora2
    medida_upch_hora_03=  "%.03f " % medida_upch.hora3
    medida_upch_hora_04=  "%.03f " % medida_upch.hora4
    medida_upch_hora_05=  "%.03f " % medida_upch.hora5
    medida_upch_hora_06=  "%.03f " % medida_upch.hora6
    medida_upch_hora_07=  "%.03f " % medida_upch.hora7
    medida_upch_hora_08=  "%.03f " % medida_upch.hora8
    medida_upch_hora_09=  "%.03f " % medida_upch.hora9
    medida_upch_hora_10=  "%.03f " % medida_upch.hora10
    medida_upch_hora_11=  "%.03f " % medida_upch.hora11
    medida_upch_hora_12=  "%.03f " % medida_upch.hora12
    medida_upch_hora_13=  "%.03f " % medida_upch.hora13
    medida_upch_hora_14=  "%.03f " % medida_upch.hora14
    medida_upch_hora_15=  "%.03f " % medida_upch.hora15
    medida_upch_hora_16=  "%.03f " % medida_upch.hora16
    medida_upch_hora_17=  "%.03f " % medida_upch.hora17
    medida_upch_hora_18=  "%.03f " % medida_upch.hora18
    medida_upch_hora_19=  "%.03f " % medida_upch.hora19
    medida_upch_hora_20=  "%.03f " % medida_upch.hora20
    medida_upch_hora_21=  "%.03f " % medida_upch.hora21
    medida_upch_hora_22=  "%.03f " % medida_upch.hora22
    medida_upch_hora_23=  "%.03f " % medida_upch.hora23
    medida_upch_hora_24=  "%.03f " % medida_upch.hora24



    #circulante
    medida_circulante_hora_01=  "%.03f " % medida_circulante.hora1
    medida_circulante_hora_02=  "%.03f " % medida_circulante.hora2
    medida_circulante_hora_03=  "%.03f " % medida_circulante.hora3
    medida_circulante_hora_04=  "%.03f " % medida_circulante.hora4
    medida_circulante_hora_05=  "%.03f " % medida_circulante.hora5
    medida_circulante_hora_06=  "%.03f " % medida_circulante.hora6
    medida_circulante_hora_07=  "%.03f " % medida_circulante.hora7
    medida_circulante_hora_08=  "%.03f " % medida_circulante.hora8
    medida_circulante_hora_09=  "%.03f " % medida_circulante.hora9
    medida_circulante_hora_10=  "%.03f " % medida_circulante.hora10
    medida_circulante_hora_11=  "%.03f " % medida_circulante.hora11
    medida_circulante_hora_12=  "%.03f " % medida_circulante.hora12
    medida_circulante_hora_13=  "%.03f " % medida_circulante.hora13
    medida_circulante_hora_14=  "%.03f " % medida_circulante.hora14
    medida_circulante_hora_15=  "%.03f " % medida_circulante.hora15
    medida_circulante_hora_16=  "%.03f " % medida_circulante.hora16
    medida_circulante_hora_17=  "%.03f " % medida_circulante.hora17
    medida_circulante_hora_18=  "%.03f " % medida_circulante.hora18
    medida_circulante_hora_19=  "%.03f " % medida_circulante.hora19
    medida_circulante_hora_20=  "%.03f " % medida_circulante.hora20
    medida_circulante_hora_21=  "%.03f " % medida_circulante.hora21
    medida_circulante_hora_22=  "%.03f " % medida_circulante.hora22
    medida_circulante_hora_23=  "%.03f " % medida_circulante.hora23
    medida_circulante_hora_24=  "%.03f " % medida_circulante.hora24



    #puntilla
    medida_puntilla_hora_01=  "%.03f " % medida_puntilla.hora1
    medida_puntilla_hora_02=  "%.03f " % medida_puntilla.hora2
    medida_puntilla_hora_03=  "%.03f " % medida_puntilla.hora3
    medida_puntilla_hora_04=  "%.03f " % medida_puntilla.hora4
    medida_puntilla_hora_05=  "%.03f " % medida_puntilla.hora5
    medida_puntilla_hora_06=  "%.03f " % medida_puntilla.hora6
    medida_puntilla_hora_07=  "%.03f " % medida_puntilla.hora7
    medida_puntilla_hora_08=  "%.03f " % medida_puntilla.hora8
    medida_puntilla_hora_09=  "%.03f " % medida_puntilla.hora9
    medida_puntilla_hora_10=  "%.03f " % medida_puntilla.hora10
    medida_puntilla_hora_11=  "%.03f " % medida_puntilla.hora11
    medida_puntilla_hora_12=  "%.03f " % medida_puntilla.hora12
    medida_puntilla_hora_13=  "%.03f " % medida_puntilla.hora13
    medida_puntilla_hora_14=  "%.03f " % medida_puntilla.hora14
    medida_puntilla_hora_15=  "%.03f " % medida_puntilla.hora15
    medida_puntilla_hora_16=  "%.03f " % medida_puntilla.hora16
    medida_puntilla_hora_17=  "%.03f " % medida_puntilla.hora17
    medida_puntilla_hora_18=  "%.03f " % medida_puntilla.hora18
    medida_puntilla_hora_19=  "%.03f " % medida_puntilla.hora19
    medida_puntilla_hora_20=  "%.03f " % medida_puntilla.hora20
    medida_puntilla_hora_21=  "%.03f " % medida_puntilla.hora21
    medida_puntilla_hora_22=  "%.03f " % medida_puntilla.hora22
    medida_puntilla_hora_23=  "%.03f " % medida_puntilla.hora23
    medida_puntilla_hora_24=  "%.03f " % medida_puntilla.hora24




    #exceso
    medida_exceso_hora_01=  "%.03f " % medida_exceso.hora1
    medida_exceso_hora_02=  "%.03f " % medida_exceso.hora2
    medida_exceso_hora_03=  "%.03f " % medida_exceso.hora3
    medida_exceso_hora_04=  "%.03f " % medida_exceso.hora4
    medida_exceso_hora_05=  "%.03f " % medida_exceso.hora5
    medida_exceso_hora_06=  "%.03f " % medida_exceso.hora6
    medida_exceso_hora_07=  "%.03f " % medida_exceso.hora7
    medida_exceso_hora_08=  "%.03f " % medida_exceso.hora8
    medida_exceso_hora_09=  "%.03f " % medida_exceso.hora9
    medida_exceso_hora_10=  "%.03f " % medida_exceso.hora10
    medida_exceso_hora_11=  "%.03f " % medida_exceso.hora11
    medida_exceso_hora_12=  "%.03f " % medida_exceso.hora12
    medida_exceso_hora_13=  "%.03f " % medida_exceso.hora13
    medida_exceso_hora_14=  "%.03f " % medida_exceso.hora14
    medida_exceso_hora_15=  "%.03f " % medida_exceso.hora15
    medida_exceso_hora_16=  "%.03f " % medida_exceso.hora16
    medida_exceso_hora_17=  "%.03f " % medida_exceso.hora17
    medida_exceso_hora_18=  "%.03f " % medida_exceso.hora18
    medida_exceso_hora_19=  "%.03f " % medida_exceso.hora19
    medida_exceso_hora_20=  "%.03f " % medida_exceso.hora20
    medida_exceso_hora_21=  "%.03f " % medida_exceso.hora21
    medida_exceso_hora_22=  "%.03f " % medida_exceso.hora22
    medida_exceso_hora_23=  "%.03f " % medida_exceso.hora23
    medida_exceso_hora_24=  "%.03f " % medida_exceso.hora24





    #hm
    medida_hm_hora_01=  "%.03f " % medida_hm.hora1
    medida_hm_hora_02=  "%.03f " % medida_hm.hora2
    medida_hm_hora_03=  "%.03f " % medida_hm.hora3
    medida_hm_hora_04=  "%.03f " % medida_hm.hora4
    medida_hm_hora_05=  "%.03f " % medida_hm.hora5
    medida_hm_hora_06=  "%.03f " % medida_hm.hora6
    medida_hm_hora_07=  "%.03f " % medida_hm.hora7
    medida_hm_hora_08=  "%.03f " % medida_hm.hora8
    medida_hm_hora_09=  "%.03f " % medida_hm.hora9
    medida_hm_hora_10=  "%.03f " % medida_hm.hora10
    medida_hm_hora_11=  "%.03f " % medida_hm.hora11
    medida_hm_hora_12=  "%.03f " % medida_hm.hora12
    medida_hm_hora_13=  "%.03f " % medida_hm.hora13
    medida_hm_hora_14=  "%.03f " % medida_hm.hora14
    medida_hm_hora_15=  "%.03f " % medida_hm.hora15
    medida_hm_hora_16=  "%.03f " % medida_hm.hora16
    medida_hm_hora_17=  "%.03f " % medida_hm.hora17
    medida_hm_hora_18=  "%.03f " % medida_hm.hora18
    medida_hm_hora_19=  "%.03f " % medida_hm.hora19
    medida_hm_hora_20=  "%.03f " % medida_hm.hora20
    medida_hm_hora_21=  "%.03f " % medida_hm.hora21
    medida_hm_hora_22=  "%.03f " % medida_hm.hora22
    medida_hm_hora_23=  "%.03f " % medida_hm.hora23
    medida_hm_hora_24=  "%.03f " % medida_hm.hora24




    #q
    medida_q_hora_01=  "%.03f " % medida_q.hora1
    medida_q_hora_02=  "%.03f " % medida_q.hora2
    medida_q_hora_03=  "%.03f " % medida_q.hora3
    medida_q_hora_04=  "%.03f " % medida_q.hora4
    medida_q_hora_05=  "%.03f " % medida_q.hora5
    medida_q_hora_06=  "%.03f " % medida_q.hora6
    medida_q_hora_07=  "%.03f " % medida_q.hora7
    medida_q_hora_08=  "%.03f " % medida_q.hora8
    medida_q_hora_09=  "%.03f " % medida_q.hora9
    medida_q_hora_10=  "%.03f " % medida_q.hora10
    medida_q_hora_11=  "%.03f " % medida_q.hora11
    medida_q_hora_12=  "%.03f " % medida_q.hora12
    medida_q_hora_13=  "%.03f " % medida_q.hora13
    medida_q_hora_14=  "%.03f " % medida_q.hora14
    medida_q_hora_15=  "%.03f " % medida_q.hora15
    medida_q_hora_16=  "%.03f " % medida_q.hora16
    medida_q_hora_17=  "%.03f " % medida_q.hora17
    medida_q_hora_18=  "%.03f " % medida_q.hora18
    medida_q_hora_19=  "%.03f " % medida_q.hora19
    medida_q_hora_20=  "%.03f " % medida_q.hora20
    medida_q_hora_21=  "%.03f " % medida_q.hora21
    medida_q_hora_22=  "%.03f " % medida_q.hora22
    medida_q_hora_23=  "%.03f " % medida_q.hora23
    medida_q_hora_24=  "%.03f " % medida_q.hora24


    #Chancay
    promedio_chancay_hora_12 =  "%.03f " % medida_chancay.obtener_promedio_12_horas()
    promedio_chancay_hora_18 =  "%.03f " % medida_chancay.obtener_promedio_18_horas()
    promedio_chancay_hora_24 =  "%.03f " % medida_chancay.obtener_promedio_24_horas()
    promedio_chancay =  "%.03f " % medida_chancay.obtener_promedio_del_dia()
    promedio_chancay_hora_06 =  "%.03f " % medida_chancay.obtener_promedio_06_horas()
    masa_chancay =  "%.03f " % medida_chancay.obtener_masa_diaria()
    max_chancay =  "%.03f " % medida_chancay.obtener_maxima()
    min_chancay =  "%.03f " % medida_chancay.obtener_minima()

    #Compuerta del Rio
    promedio_compuerta_hora_12 =  "%.03f " % medida_compuerta.obtener_promedio_12_horas()
    promedio_compuerta_hora_18 =  "%.03f " % medida_compuerta.obtener_promedio_18_horas()
    promedio_compuerta_hora_24 =  "%.03f " % medida_compuerta.obtener_promedio_24_horas()
    promedio_compuerta =  "%.03f " % medida_compuerta.obtener_promedio_del_dia()
    promedio_compuerta_hora_06 =  "%.03f " % medida_compuerta.obtener_promedio_06_horas()
    masa_compuerta =  "%.03f " % medida_compuerta.obtener_masa_diaria()
    max_compuerta =  "%.03f " % medida_compuerta.obtener_maxima()
    min_compuerta =  "%.03f " % medida_compuerta.obtener_minima()

    #Alimentador
    promedio_alimentador_hora_12 =  "%.03f " % medida_alimentador.obtener_promedio_12_horas()
    promedio_alimentador_hora_18 =  "%.03f " % medida_alimentador.obtener_promedio_18_horas()
    promedio_alimentador_hora_24 =  "%.03f " % medida_alimentador.obtener_promedio_24_horas()
    promedio_alimentador =  "%.03f " % medida_alimentador.obtener_promedio_del_dia()
    promedio_alimentador_hora_06 =  "%.03f " % medida_alimentador.obtener_promedio_06_horas()
    masa_alimentador =  "%.03f " % medida_alimentador.obtener_masa_diaria()
    max_alimentador =  "%.03f " % medida_alimentador.obtener_maxima()
    min_alimentador =  "%.03f " % medida_alimentador.obtener_minima()

    #aporte
    promedio_aporte_hora_12 =  "%.03f " % medida_aporte.obtener_promedio_12_horas()
    promedio_aporte_hora_18 =  "%.03f " % medida_aporte.obtener_promedio_18_horas()
    promedio_aporte_hora_24 =  "%.03f " % medida_aporte.obtener_promedio_24_horas()
    promedio_aporte =  "%.03f " % medida_aporte.obtener_promedio_del_dia()
    promedio_aporte_hora_06 =  "%.03f " % medida_aporte.obtener_promedio_06_horas()
    masa_aporte =  "%.03f " % medida_aporte.obtener_masa_diaria()
    max_aporte =  "%.03f " % medida_aporte.obtener_maxima()
    min_aporte =  "%.03f " % medida_aporte.obtener_minima()
 

    #descarga
    promedio_descarga_hora_12 =  "%.03f " % medida_descarga.obtener_promedio_12_horas()
    promedio_descarga_hora_18 =  "%.03f " % medida_descarga.obtener_promedio_18_horas()
    promedio_descarga_hora_24 =  "%.03f " % medida_descarga.obtener_promedio_24_horas()
    promedio_descarga =  "%.03f " % medida_descarga.obtener_promedio_del_dia()
    promedio_descarga_hora_06 =  "%.03f " % medida_descarga.obtener_promedio_06_horas()
    masa_descarga =  "%.03f " % medida_descarga.obtener_masa_diaria()
    max_descarga =  "%.03f " % medida_descarga.obtener_maxima()
    min_descarga =  "%.03f " % medida_descarga.obtener_minima()


    #majin
    promedio_majin_hora_12 =  "%.03f " % medida_majin.obtener_promedio_12_horas()
    promedio_majin_hora_18 =  "%.03f " % medida_majin.obtener_promedio_18_horas()
    promedio_majin_hora_24 =  "%.03f " % medida_majin.obtener_promedio_24_horas()
    promedio_majin =  "%.03f " % medida_majin.obtener_promedio_del_dia()
    promedio_majin_hora_06 =  "%.03f " % medida_majin.obtener_promedio_06_horas()
    masa_majin =  "%.03f " % medida_majin.obtener_masa_diaria()
    max_majin =  "%.03f " % medida_majin.obtener_maxima()
    min_majin =  "%.03f " % medida_majin.obtener_minima()

    #upch
    promedio_upch_hora_12 =  "%.03f " % medida_upch.obtener_promedio_12_horas()
    promedio_upch_hora_18 =  "%.03f " % medida_upch.obtener_promedio_18_horas()
    promedio_upch_hora_24 =  "%.03f " % medida_upch.obtener_promedio_24_horas()
    promedio_upch =  "%.03f " % medida_upch.obtener_promedio_del_dia()
    promedio_upch_hora_06 =  "%.03f " % medida_upch.obtener_promedio_06_horas()
    masa_upch =  "%.03f " % medida_upch.obtener_masa_diaria()
    max_upch =  "%.03f " % medida_upch.obtener_maxima()
    min_upch =  "%.03f " % medida_upch.obtener_minima()


   #circulante
    promedio_circulante_hora_12 =  "%.03f " % medida_circulante.obtener_promedio_12_horas()
    promedio_circulante_hora_18 =  "%.03f " % medida_circulante.obtener_promedio_18_horas()
    promedio_circulante_hora_24 =  "%.03f " % medida_circulante.obtener_promedio_24_horas()
    promedio_circulante =  "%.03f " % medida_circulante.obtener_promedio_del_dia()
    promedio_circulante_hora_06 =  "%.03f " % medida_circulante.obtener_promedio_06_horas()
    masa_circulante =  "%.03f " % medida_circulante.obtener_masa_diaria()
    max_circulante =  "%.03f " % medida_circulante.obtener_maxima()
    min_circulante =  "%.03f " % medida_circulante.obtener_minima()


   #puntilla
    promedio_puntilla_hora_12 =  "%.03f " % medida_puntilla.obtener_promedio_12_horas()
    promedio_puntilla_hora_18 =  "%.03f " % medida_puntilla.obtener_promedio_18_horas()
    promedio_puntilla_hora_24 =  "%.03f " % medida_puntilla.obtener_promedio_24_horas()
    promedio_puntilla =  "%.03f " % medida_puntilla.obtener_promedio_del_dia()
    promedio_puntilla_hora_06 =  "%.03f " % medida_puntilla.obtener_promedio_06_horas()
    masa_puntilla =  "%.03f " % medida_puntilla.obtener_masa_diaria()
    max_puntilla =  "%.03f " % medida_puntilla.obtener_maxima()
    min_puntilla =  "%.03f " % medida_puntilla.obtener_minima()


    #exceso
    promedio_exceso_hora_12 =  "%.03f " % medida_exceso.obtener_promedio_12_horas()
    promedio_exceso_hora_18 =  "%.03f " % medida_exceso.obtener_promedio_18_horas()
    promedio_exceso_hora_24 =  "%.03f " % medida_exceso.obtener_promedio_24_horas()
    promedio_exceso =  "%.03f " % medida_exceso.obtener_promedio_del_dia()
    promedio_exceso_hora_06 =  "%.03f " % medida_exceso.obtener_promedio_06_horas()
    masa_exceso =  "%.03f " % medida_exceso.obtener_masa_diaria()
    max_exceso =  "%.03f " % medida_exceso.obtener_maxima()
    min_exceso =  "%.03f " % medida_exceso.obtener_minima()

   #q
    promedio_q_hora_12 =  "%.03f " % medida_q.obtener_promedio_12_horas()
    promedio_q_hora_18 =  "%.03f " % medida_q.obtener_promedio_18_horas()
    promedio_q_hora_24 =  "%.03f " % medida_q.obtener_promedio_24_horas()
    promedio_q =  "%.03f " % medida_q.obtener_promedio_del_dia()
    promedio_q_hora_06 =  "%.03f " % medida_q.obtener_promedio_06_horas()
    masa_q =  "%.03f " % medida_q.obtener_masa_diaria()
    max_q =  "%.03f " % medida_q.obtener_maxima()
    min_q =  "%.03f " % medida_q.obtener_minima()

    #hm
    promedio_hm_hora_12 =  "%.03f " % medida_hm.obtener_promedio_12_horas()
    promedio_hm_hora_18 =  "%.03f " % medida_hm.obtener_promedio_18_horas()
    promedio_hm_hora_24 =  "%.03f " % medida_hm.obtener_promedio_24_horas()
    promedio_hm =  "%.03f " % medida_hm.obtener_promedio_del_dia()
    promedio_hm_hora_06 =  "%.03f " % medida_hm.obtener_promedio_06_horas()
    masa_hm =  "%.03f " % medida_hm.obtener_masa_diaria()
    max_hm =  "%.03f " % medida_hm.obtener_maxima()
    min_hm =  "%.03f " % medida_hm.obtener_minima()

    fecha = radiograma.fecha

    html = render_to_string('reporte_diario_medidas.html', locals(), context_instance=RequestContext(request))
    return generar_pdf(html)


def balance_pdf(request):
    # vista de ejemplo con un hipotético modelo Libro
    pagesize = "A4"
    radiograma=get_object_or_404(Radiograma, id=2)   

    radiograma_anterior = radiograma.obtener_radiograma_anterior()
    fecha = radiograma.fecha
    balance_alimentador = "{:,}".format(radiograma_anterior.obtener_balance_del_alimentador())
    balance_descarga = "{:,}".format(radiograma_anterior.obtener_balance_del_descarga())
    balance_majin = "{:,}".format(radiograma_anterior.obtener_balance_majin())
    balance_filtro = "{:,}".format(radiograma.obtener_balance_filtro())
    balance_volumen = "{:,}".format(radiograma_anterior.obtener_balance_del_alimentador() - radiograma_anterior.obtener_balance_del_descarga() - radiograma_anterior.obtener_balance_majin() - radiograma.obtener_balance_filtro())
    balance_volumen_metros = round( ( (radiograma_anterior.obtener_balance_del_alimentador() - radiograma_anterior.obtener_balance_del_descarga() - radiograma_anterior.obtener_balance_majin() - radiograma.obtener_balance_filtro())  / 86400), 3)
    balance_valor_teorico = round(radiograma_anterior.obtener_volumen() + (radiograma_anterior.obtener_balance_del_alimentador() - radiograma_anterior.obtener_balance_del_descarga() - radiograma_anterior.obtener_balance_majin() - radiograma.obtener_balance_filtro()))
    balance_numero_dias_restantes = round(radiograma.obtener_dias_restantes_mes(), 0)
    balance_numero_dias_total_mes = round(radiograma.obtener_dias_del_mes(), 0)
    # balance_volumen * dias del total del mes o dias restantes
    balance_variacion_mes = round(((radiograma_anterior.obtener_balance_del_alimentador() - radiograma_anterior.obtener_balance_del_descarga() - radiograma_anterior.obtener_balance_majin() - radiograma.obtener_balance_filtro()) * (balance_numero_dias_restantes -1 )) , 0)
    balance_reservorio_proyectado_mensual = radiograma.obtener_volumen() + balance_variacion_mes
    # redondeado a 3 cifras
    balance_diferencia_volumenes = round(radiograma.obtener_volumen() - balance_valor_teorico, 3)
    balance_diferencia_volumenes_metros = round((balance_diferencia_volumenes / 86400), 3)
    balance_variacion_nivel = round((radiograma.reservorio_cota - radiograma_anterior.reservorio_cota), 3)

    html = render_to_string('reporte_diario_balance_reservorio.html', locals(), context_instance=RequestContext(request))
    return generar_pdf(html)


def consolidado_medidas_mensual_pdf(request):
    pagesize = "A4"
    radiogramas = Radiograma.obtener_resumen_mensual(2011, 4)
    resultados = Radiograma.obtener_promedios_mensuales(radiogramas)

    html = render_to_string('consolidado_mesual_medidas.html', locals(), context_instance=RequestContext(request))
    return generar_pdf(html)

def consolidado_radiograma_mensual_pdf(request):
    pagesize = "A4"
    radiogramas = Radiograma.obtener_resumen_radiograma(2011, 4)
    html = render_to_string('consolidado_mensual_radiograma.html', locals(), context_instance=RequestContext(request))
    return generar_pdf(html)

def consolidado_mensual_chonchano_pdf(request):
    pagesize = "A4"
    radiogramas = Radiograma.obtener_resumen_chonchano(2011, 4)
    html = render_to_string('consolidado_mensual_chonchano.html', locals(), context_instance=RequestContext(request))
    return generar_pdf(html)

def consolidado_mensual_chotano_pdf(request):
    pagesize = "A4"
    radiogramas = Radiograma.obtener_resumen_chotano(2011, 4)
    html = render_to_string('consolidado_mensual_chotano.html', locals(), context_instance=RequestContext(request))
    return generar_pdf(html)

def consolidado_mensual_chancay_pdf(request):
    pagesize = "A4"
    radiogramas = Radiograma.obtener_resumen_chancay(2011, 4)
    html = render_to_string('consolidado_mensual_chancay.html', locals(), context_instance=RequestContext(request))
    return generar_pdf(html)

def consolidado_mensual_hidrometria_sistema_mayor_pdf(request):
    pagesize = "A4"
    html = render_to_string('consolidado_hidrometria_mensual_sistema_mayor.html', locals(), context_instance=RequestContext(request))
    return generar_pdf(html)


def consolidado_informacion_tinajones_pdf(request):
    pagesize = "A4"
    valor = Tinajones.obtener_listado()
    html = render_to_string('reporte_informacion_tinajones.html', locals(), context_instance=RequestContext(request))
    return generar_pdf(html)





def reporte_radiograma_usuarios_pdf(request):
    # vista de ejemplo con un hipotético modelo Libro
    pagesize = "A4"
    radiograma=get_object_or_404(Radiograma, id=6)   
    radiograma_anterior = radiograma.obtener_radiograma_anterior()
     
    medida_chancay_anterior = Medida.objects.get(parametro=1,radiograma=radiograma_anterior.id)
    medida_compuerta_anterior = Medida.objects.get(parametro=2,radiograma=radiograma_anterior.id)
    medida_alimentador_anterior = Medida.objects.get(parametro=3,radiograma=radiograma_anterior.id)
    medida_aporte_anterior = Medida.objects.get(parametro=4,radiograma=radiograma_anterior.id)
    medida_descarga_anterior = Medida.objects.get(parametro=5,radiograma=radiograma_anterior.id)
    medida_majin_anterior = Medida.objects.get(parametro=6,radiograma=radiograma_anterior.id)
    medida_upch_anterior = Medida.objects.get(parametro=7,radiograma=radiograma_anterior.id)
    medida_circulante_anterior = Medida.objects.get(parametro=8,radiograma=radiograma_anterior.id)
    medida_puntilla_anterior = Medida.objects.get(parametro=9,radiograma=radiograma_anterior.id)
    medida_exceso_anterior = Medida.objects.get(parametro=10,radiograma=radiograma_anterior.id)
    medida_q_anterior = Medida.objects.get(parametro=11,radiograma=radiograma_anterior.id)
    medida_hm_anterior = Medida.objects.get(parametro=12,radiograma=radiograma_anterior.id)


    medida_chancay = Medida.objects.get(parametro=1,radiograma=radiograma.id)
    medida_compuerta = Medida.objects.get(parametro=2,radiograma=radiograma.id)
    medida_alimentador = Medida.objects.get(parametro=3,radiograma=radiograma.id)
    medida_aporte = Medida.objects.get(parametro=4,radiograma=radiograma.id)
    medida_descarga = Medida.objects.get(parametro=5,radiograma=radiograma.id)
    medida_majin = Medida.objects.get(parametro=6,radiograma=radiograma.id)
    medida_upch = Medida.objects.get(parametro=7,radiograma=radiograma.id)
    medida_circulante = Medida.objects.get(parametro=8,radiograma=radiograma.id)
    medida_puntilla = Medida.objects.get(parametro=9,radiograma=radiograma.id)
    medida_exceso = Medida.objects.get(parametro=10,radiograma=radiograma.id)
    medida_q = Medida.objects.get(parametro=11,radiograma=radiograma.id)
    medida_hm = Medida.objects.get(parametro=12,radiograma=radiograma.id)


    
    promedio_chancay_hora_12 = "%.03f " % medida_chancay_anterior.obtener_promedio_12_horas()
    promedio_chancay_hora_18 = "%.03f " % medida_chancay_anterior.obtener_promedio_18_horas()
    promedio_chancay_hora_24 = "%.03f " % medida_chancay_anterior.obtener_promedio_18_horas()
    promedio_Chancay = "%.03f " % medida_chancay_anterior.obtener_promedio_del_dia()
    promedio_chancay_hora_06 = "%.03f " % medida_chancay.obtener_promedio_06_horas()
    medida_chancay_hora_08 = "%.03f " % medida_chancay.hora8


    promedio_compuerta_hora_12 = "%.03f " % medida_compuerta_anterior.obtener_promedio_12_horas()
    promedio_compuerta_hora_18 = "%.03f " % medida_compuerta_anterior.obtener_promedio_18_horas()
    promedio_compuerta_hora_24 = "%.03f " % medida_compuerta_anterior.obtener_promedio_18_horas()
    promedio_compuerta = "%.03f " %medida_compuerta.obtener_promedio_del_dia()
    promedio_compuerta_hora_06 = "%.03f " % medida_compuerta.obtener_promedio_06_horas()
    medida_compuerta_hora_08 = "%.03f " % medida_compuerta.hora8


    promedio_alimentador_hora_12 =  "%.03f " % medida_alimentador_anterior.obtener_promedio_12_horas()
    promedio_alimentador_hora_18 =  "%.03f " % medida_alimentador_anterior.obtener_promedio_18_horas()
    promedio_alimentador_hora_24 =  "%.03f " % medida_alimentador_anterior.obtener_promedio_18_horas()
    promedio_alimentador =  "%.03f " % medida_alimentador_anterior.obtener_promedio_del_dia()
    promedio_alimentador_hora_06 =  "%.03f " % medida_alimentador.obtener_promedio_06_horas()
    medida_alimentador_hora_08 =  "%.03f " % medida_alimentador.hora8



    promedio_aporte_hora_12 =  "%.03f " %  medida_aporte_anterior.obtener_promedio_12_horas()
    promedio_aporte_hora_18 =  "%.03f " %  medida_aporte_anterior.obtener_promedio_18_horas()
    promedio_aporte_hora_24 = "%.03f "  %  medida_aporte_anterior.obtener_promedio_18_horas()
    promedio_aporte =  "%.03f " %  medida_aporte_anterior.obtener_promedio_del_dia()
    promedio_aporte_hora_06 =  "%.03f " %  medida_aporte.obtener_promedio_06_horas()
    medida_aporte_hora_08 =  "%.03f " %  medida_aporte.hora8


    promedio_descarga_hora_12 = "%.03f "  %  medida_descarga_anterior.obtener_promedio_12_horas()
    promedio_descarga_hora_18 =  "%.03f "  % medida_descarga_anterior.obtener_promedio_18_horas()
    promedio_descarga_hora_24 =  "%.03f " %  medida_descarga_anterior.obtener_promedio_18_horas()
    promedio_descarga =  "%.03f "  % medida_descarga_anterior.obtener_promedio_del_dia()
    promedio_descarga_hora_06 =  "%.03f " %  medida_descarga.obtener_promedio_06_horas()
    medida_descarga_hora_08 = "%.03f " % medida_descarga.hora8


    promedio_majin_hora_12 = "%.03f " %  medida_majin_anterior.obtener_promedio_12_horas()
    promedio_majin_hora_18 = "%.03f " %  medida_majin_anterior.obtener_promedio_18_horas()
    promedio_majin_hora_24 = "%.03f " %  medida_majin_anterior.obtener_promedio_18_horas()
    promedio_majin = "%.03f " %  medida_majin_anterior.obtener_promedio_del_dia()
    promedio_majin_hora_06 = "%.03f " %  medida_majin.obtener_promedio_06_horas()
    medida_majin_hora_08 = "%.03f " %   medida_majin.hora8


    promedio_upch_hora_12 = "%.03f " %  medida_upch_anterior.obtener_promedio_12_horas()
    promedio_upch_hora_18 = "%.03f " %  medida_upch_anterior.obtener_promedio_18_horas()
    promedio_upch_hora_24 ="%.03f " %   medida_upch_anterior.obtener_promedio_18_horas()
    promedio_upch = "%.03f " %  medida_upch_anterior.obtener_promedio_del_dia()
    promedio_upch_hora_06 = "%.03f " %  medida_upch.obtener_promedio_06_horas()
    medida_upch_hora_08 = "%.03f " %  medida_upch.hora8


    promedio_circulante_hora_12 = "%.03f " %  medida_circulante_anterior.obtener_promedio_12_horas()
    promedio_circulante_hora_18 = "%.03f "  % medida_circulante_anterior.obtener_promedio_18_horas()
    promedio_circulante_hora_24 = "%.03f " %  medida_circulante_anterior.obtener_promedio_18_horas()
    promedio_circulante =  "%.03f "  % medida_circulante_anterior.obtener_promedio_del_dia()
    promedio_circulante_hora_06 =  "%.03f " %  medida_circulante.obtener_promedio_06_horas()
    medida_circulante_hora_08 = "%.03f "  %  medida_circulante.hora8


    promedio_puntilla_hora_12 =  "%.03f "  % medida_puntilla_anterior.obtener_promedio_12_horas()
    promedio_puntilla_hora_18 =  "%.03f "  % medida_puntilla_anterior.obtener_promedio_18_horas()
    promedio_puntilla_hora_24 =  "%.03f " %  medida_puntilla_anterior.obtener_promedio_18_horas()
    promedio_puntilla =  "%.03f " %  medida_puntilla_anterior.obtener_promedio_del_dia()
    promedio_puntilla_hora_06 =  "%.03f " %  medida_puntilla.obtener_promedio_06_horas()
    medida_puntilla_hora_08 =  "%.03f " %  medida_puntilla.hora8


    promedio_exceso_hora_12 = "%.03f " %  medida_exceso_anterior.obtener_promedio_12_horas()
    promedio_exceso_hora_18 = "%.03f " %  medida_exceso_anterior.obtener_promedio_18_horas()
    promedio_exceso_hora_24 = "%.03f " %  medida_exceso_anterior.obtener_promedio_18_horas()
    promedio_exceso = "%.03f " %  medida_exceso_anterior.obtener_promedio_del_dia()
    promedio_exceso_hora_06 = "%.03f " %  medida_exceso.obtener_promedio_06_horas()
    medida_exceso_hora_08 = "%.03f " %  medida_exceso.hora8



    promedio_q_hora_12 = "%.03f " %  medida_q_anterior.obtener_promedio_12_horas()
    promedio_q_hora_18 = "%.03f " %  medida_q_anterior.obtener_promedio_18_horas()
    promedio_q_hora_24 = "%.03f " %  medida_q_anterior.obtener_promedio_18_horas()
    promedio_q = "%.03f " %  medida_q_anterior.obtener_promedio_del_dia()
    promedio_q_hora_06 = "%.03f " %  medida_q.obtener_promedio_06_horas()
    medida_q_hora_08 = "%.03f " %  medida_q.hora8


    promedio_hm_hora_12 = "%.03f " %  medida_hm_anterior.obtener_promedio_12_horas()
    promedio_hm_hora_18 = "%.03f " %  medida_hm_anterior.obtener_promedio_18_horas()
    promedio_hm_hora_24 = "%.03f " %  medida_hm_anterior.obtener_promedio_18_horas()
    promedio_hm = "%.03f " %  medida_hm_anterior.obtener_promedio_del_dia()
    promedio_hm_hora_06 = "%.03f " %  medida_hm.obtener_promedio_06_horas()
    medida_hm_hora_08 = "%.03f " %  medida_hm.hora8



    reservorio_cota =  "%.03f " %  radiograma.reservorio_cota
    reservorio_volumen =  "{:,}".format(radiograma.obtener_volumen())
    reservorio_perdidas = "{:,}".format(radiograma.obtener_perdidas())
    reservorio_evaporacion = "%.02f " % radiograma.reservorio_evaporacion
    reservorio_temperatura_maxima = "%.02f " % radiograma.reservorio_temperatura_maxima
    reservorio_temperatura_minima = "%.02f " % radiograma.reservorio_temperatura_minima
    reservorio_humedad_relativa = "%.02f " % radiograma.reservorio_humedad_relativa
    reservorio_precipitacion = "%.02f " % radiograma.reservorio_precipitacion
    reservorio_hora_precipitacion = radiograma.reservorio_hora_precipitacion
    max_chancay = "%.03f " % medida_chancay_anterior.obtener_maxima()
    min_chancay = "%.03f " % medida_chancay_anterior.obtener_minima()
    max_chancay_hora = medida_chancay_anterior.obtener_hora_maxima()
    min_chancay_hora = medida_chancay_anterior.obtener_hora_minima()


    trasvase_tunel_chonchano = "%.03f " % radiograma.trasvase_tunel_chonchano
    chonchano_seis_horas = "%.03f " % radiograma.chonchano_seishoras
    chotano_estado_tiempo = radiograma.chotano_estado_tiempo
    trasvase_tunel_chotano = "%.03f " % radiograma.trasvase_tunel_chotano
    chotano_seis_horas = "%.03f " % radiograma.chotano_seishoras
    chotano_humedad_relativa = "%.02f " % radiograma.chotano_humedad_relativa
    chotano_temperatura_maxima = "%.02f " % radiograma.chotano_temperatura_maxima
    chotano_temperatura_mimino = "%.02f " % radiograma.chotano_temperatura_mimino
    chotano_precipitacion =  "%.02f " % radiograma.chotano_precipitacion
    chotano_precipitacion_hora = radiograma.chotano_precipitacion_hora

    observacion = radiograma.observacion
    numero_radiograma = radiograma.numero
    fecha = radiograma.fecha

    html = render_to_string('reporte_diario_radiograma_usuarios.html', locals(), context_instance=RequestContext(request))
    return generar_pdf(html)
