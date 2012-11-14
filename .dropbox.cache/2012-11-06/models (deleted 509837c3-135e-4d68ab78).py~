#! /usr/bin/python
# -*- coding: UTF-8-*-
from django.db import models
from django.utils import timezone
import datetime
# Create your models here.
import calendar
from datetime import datetime, timedelta
from django.contrib.auth.models import User, Group
from django.core import validators


class Area(models.Model):
	nombre = models.CharField("nombre", max_length=100)
	activo = models.BooleanField(default=True, verbose_name="Activo?")
   	created_at = models.DateTimeField(auto_now_add=True, verbose_name="Fecha de registro")
   	updated_at = models.DateTimeField(auto_now=True, verbose_name="Fecha de actualización")
   	ip_address = models.IPAddressField()
   	host_name = models.CharField(max_length=50)
   	user = models.ForeignKey(User)

	def __unicode__(self):
		return u"%s" % (self.nombre)

class Persona(models.Model):
	nombre = models.CharField("nombre", max_length=200)
	apellidos = models.CharField("apellido", max_length=200)
	area = models.ForeignKey(Area)
	activo = models.BooleanField(default=True, verbose_name="Activo?")
   	created_at = models.DateTimeField(auto_now_add=True, verbose_name="Fecha de registro")
	updated_at = models.DateTimeField(auto_now=True, verbose_name="Fecha de actualización")
	ip_address = models.IPAddressField()
	host_name = models.CharField(max_length=50)	
	user = models.ForeignKey(User)
	def __unicode__(self):
        	return '%s %s' % (self.nombre, self.apellidos)
	

class Categoria(models.Model):
	nombre = models.CharField(max_length=50, verbose_name="Nombre", unique="true")
	descripcion = models.CharField(max_length=100, blank=True, verbose_name="descripción")
	activo = models.BooleanField(default=True, verbose_name="Activo")
    	created_at = models.DateTimeField(auto_now_add=True)
    	updated_at = models.DateTimeField(auto_now=True)
	ip_address = models.IPAddressField()
    	host_name = models.CharField(max_length=200)
    	user = models.ForeignKey(User)
	
	def __unicode__(self):
		return self.nombre

class Tipo(models.Model):
	nombre = models.CharField(max_length=50, verbose_name="Nombre")
	categoria = models.ForeignKey(Categoria, verbose_name="Categoria")
	descripcion = models.CharField(max_length=100, blank=True, verbose_name="descripción")
	abreviatura = models.CharField(max_length=100, blank=True, verbose_name="abreviatura")  
	activo = models.BooleanField(default=True, verbose_name="Activo")
    	created_at = models.DateTimeField(auto_now_add=True)
    	updated_at = models.DateTimeField(auto_now=True)
	ip_address = models.IPAddressField()
    	host_name = models.CharField(max_length=50)
    	user = models.ForeignKey(User)
	
	def __unicode__(self):
		return self.nombre

class Dispositivo(models.Model):
	nombre = models.CharField(max_length=50, verbose_name="Nombre")
	persona = models.ForeignKey(Persona, verbose_name="Responsable del dispositivo")
	comprobante = models.CharField(max_length=70, blank=True, verbose_name="Número del Comprobante")  
	fechaIngreso = models.DateField(null=True, blank=True, verbose_name="Fecha de Alta")
	fechaSalida = models.DateField(null=True, blank=True, verbose_name="Fecha de baja Salida")	 	                   
   	activo = models.BooleanField(default=True, verbose_name="Activo?")
   	created_at = models.DateTimeField(auto_now_add=True, verbose_name="Fecha de registro")
   	updated_at = models.DateTimeField(auto_now=True, verbose_name="Fecha de actualización")
   	ip_address = models.IPAddressField()
   	host_name = models.CharField(max_length=50)
   	user = models.ForeignKey(User) 
   
	def __unicode__(self):
		return '%0*d' % (5, int(self.id)) 

class Detalle(models.Model):
	dispositivo = models.ForeignKey(Dispositivo)	
	tipo = models.ForeignKey(Tipo, verbose_name="Tipo de dispositivo")
	fechaCompra = models.DateField(null=True, blank=True, verbose_name="Fecha de compra")
	marca = models.CharField(max_length=25, blank=True, verbose_name="Marca", null=True,)
	modelo = models.CharField(max_length=20, blank=True, verbose_name="Modelo",null=True,)
   	serie = models.CharField(max_length=20, blank=True, verbose_name="Serial / Número de serie",null=True,)
	capacidad = models.CharField(max_length=10, blank=True, verbose_name="Capacidad",null=True,)
	version = models.FloatField(null=True, blank=True, verbose_name="versión")
	numeroLicencias = models.IntegerField(null=True, blank=True, verbose_name="Número de licencias")   
   	garantia = models.FloatField(null=True, blank=True, verbose_name="Garantia")                   
   	activo = models.BooleanField(default=True, verbose_name="Activo?")
   	descripcion = models.CharField(max_length=100, verbose_name="Descripción",blank=True,null=True,)
   	created_at = models.DateTimeField(auto_now_add=True, verbose_name="Fecha de registro")
   	updated_at = models.DateTimeField(auto_now=True, verbose_name="Fecha de actualizacin")
   	ip_address = models.IPAddressField()
   	host_name = models.CharField(max_length=50)
   	user = models.ForeignKey(User)
