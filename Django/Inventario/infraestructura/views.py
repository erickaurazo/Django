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
	categorias = Categoria.objects.all()
	return render_to_response('base.html', {'categorias': categorias,})

def categoria(request, id_categoria):
	categorias = Categoria.objects.all()
	nombreCategoria = Categoria.objects.get(id = id_categoria).nombre
	tipos = Tipo.objects.filter(categoria=id_categoria)
	return render_to_response('base.html', {'nombreCategoria': nombreCategoria,'categorias': categorias,'tipos': tipos,})

def dispositivo(request, id_dispositivo):
	dispositivos = Dispositivo.objects.all()
	return render_to_response('base.html', {'dispositivos': dispositivos,})



def tipo(request, id_tipo):
	categorias = Categoria.objects.all()
	nombreTipo = Tipo.objects.get(id = id_tipo).nombre
	detalles = Detalle.objects.filter(tipo=id_tipo)
	return render_to_response('base.html', {'nombreTipo' : nombreTipo, 'categorias': categorias, 'detalles': detalles,})


