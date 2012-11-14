#encoding:utf-8
from django.db import models
from django.contrib.auth.models import User
from django.utils import timezone
import datetime
# Create your models here.
import calendar
from datetime import datetime, timedelta

class Bebida(models.Model):
	nombre = models.CharField(max_length=50, verbose_name="Nombre")
	ingredientes = models.TextField(verbose_name="Ingredientes")
	preparacion = models.TextField(verbose_name="Preparación")

	def __unicode__(self):
		return self.nombre

class Receta(models.Model):
	titulo = models.CharField(max_length=100, unique=True)
	ingredientes = models.TextField(help_text='Redacta los ingredientes')
	preparacion = models.TextField(verbose_name='Preparación')
	imagen = models.ImageField(upload_to='recetas',verbose_name='Imágen')
	tiempo_registro = models.DateTimeField(auto_now=True)
	usuarios = models.ForeignKey(User)

	def __unicode__(self):
		return self.titulo



































