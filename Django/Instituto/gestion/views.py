# Create your views here.
# importamos del modelo
from models import Instituto, Grupo, Investigador
# importamos clases necesarias para el funcionamiento de la vista
from django.http import HttpResponse
# renderiza la salida en HTML mediante el template que le pasamos a la func.
from django.shortcuts import render_to_response
from django.template import Template, Context, loader
from django.template.loader import get_template

def index(request):
	# todos los institutos para el listado lateral
	institutos = Instituto.objects.all()
	# se llama al template con esta info.
	return render_to_response('aplicacion/base.html',  {'institutos': institutos,})

def instituto(request, id_instituto):
	# todos los institutos para el listado lateral
	institutos = Instituto.objects.all()
	# el nombre del instituto
	nombreInstituto  = Instituto.objects.get(id = id_instituto).nombre
	# los grupos del instituto definido por id_instituto
	grupos = Grupo.objects.filter(instituto=id_instituto)
	# se llama al template con esta info.
	return render_to_response('aplicacion/base.html', {'nombreInstituto' : nombreInstituto, 'institutos': institutos, 'grupos': grupos,})

def grupo(request, id_grupo):
	# todos los institutos para el listado lateral
	institutos = Instituto.objects.all()
	# el nombre del grupo
	nombreGrupo  = Grupo.objects.get(id = id_grupo).nombre
	# los investigadores del grupo
	investigadores = Investigador.objects.filter(grupo=id_grupo)
	# se llama al template con esta info.
	return render_to_response('aplicacion/base.html', {'nombreGrupo' : nombreGrupo, 'institutos': institutos, 'investigadores': investigadores,})
