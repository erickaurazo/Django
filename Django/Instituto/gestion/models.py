from django.db import models
from django.contrib.auth.models import User

class Instituto(models.Model):
	nombre = models.CharField("Nombre del Instituto", max_length=64)
	# __unicode__ en lugar de __str__ para evitar problemas propios del juego de caracteres
	def __unicode__(self):
		return u"%s" % (self.nombre)
	# Para que el admin lo administre
	class Admin:
		pass

class Grupo(models.Model):
	nombre = models.CharField("Grupo", max_length=64)
	instituto = models.ForeignKey(Instituto, verbose_name="Instituto al que pertenece")	
	def __unicode__(self):
		return u"%s" % (self.nombre)
	class Admin:
		pass


class Investigador(models.Model):
	nombreUsuario = models.CharField(verbose_name="Identificador del investigador", max_length=64)
	grupo = models.ForeignKey(Grupo, verbose_name="Grupo al que pertenece")
	apellidos = models.CharField(verbose_name="apellidos", max_length=64)
	nombre = models.CharField(verbose_name="nombre", max_length=64)
	def __unicode__(self):
		return u"%s" % (self.nombreUsuario)
	class Admin:
		pass
