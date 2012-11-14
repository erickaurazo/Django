# Create your views here.
# -*- coding: utf-8 -*-
import ho.pisa as pisa
import cStringIO as StringIO
import cgi
from models import Area, Persona, Categoria, Tipo, Dispositivo, Detalle
from django.template import RequestContext
from django.template.loader import render_to_string
from django.template import Template, Context, loader
from django.template.loader import get_template
from django.http import HttpResponse
from infraestructura.models import *
from django.shortcuts import get_object_or_404
# renderiza la salida en HTML mediante el template que le pasamos a la func.
from django.shortcuts import render_to_response

def index(request):
	dispositivos = Dispositivo.objects.all()
	return render_to_response('base.html', {'dispositivos': dispositivos,})

def detalle(request, id_detalle):
	detalles = Detalles.objects.all()
	return render_to_response('base.html', {'detalles': detalles,})

def dispositivo(request, id_dispositivo):
	dispositivos = Dispositivo.objects.all()
	nombreDispositivos  = Dispositivo.objects.get(id = id_tipo).nombre
	tipos  = Detalle.objects.filter(detalle=id_tipo)
	return render_to_response('base.html', {'nombreDispositivos': nombreDispositivos,'dispositivos': dispositivos,'tipos': tipos,})

def tipo(request, id_tipo):
	dispositivos = Dispositivo.objects.all()
	nombreTipo  = Tipo.objects.get(id = id_Tipo).nombre
	categorias = Categoria.objects.filter(tipo=id_categoria)
	return render_to_response('base.html', {'nombreTipo' :nombreTipo , 'dispositivos':dispositivos , 'categorias':categorias,})


