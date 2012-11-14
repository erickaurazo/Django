# -*- encoding: utf-8 -*-
from django.contrib import admin
from radiograma.models import *
from django.core.exceptions import PermissionDenied
class ParametroAdmin(admin.ModelAdmin):
	fieldsets = (
	(None, {
		'fields' : ('nombre',)
	}),
	('Opciones Avanzadas', {
		'classes':('collapse',),
		'fields': ('activo',)
	}),
	)
	list_display = ('nombre','activo',)
	search_fields = ('nombre',)
        list_filter = ('activo','created_at','updated_at',)
	date_hierarchy = 'created_at'
	list_per_page = 12
	actions = ['activar_registro','desactivar_registro',]

	def save_model(self, request, obj, form, change): 
    		obj.ip_address =  request.META['REMOTE_ADDR'] 
		obj.host_name = request.META['REMOTE_HOST']
		obj.user = request.user
        	obj.save() 

	def activar_registro(self, request, queryset):
		if request.user.has_perm('radiograma.activar_parametro'):
			rows_updated = queryset.update(activo=True)
			if rows_updated == 1:
		    		message_bit = "1 registro esta"
			else:
		    		message_bit = "%s registros estan" % rows_updated
			self.message_user(request, "%s correctamente activados." % message_bit)
		else:
			raise PermissionDenied
	activar_registro.short_description = "Marcar registros como activados"

	def desactivar_registro(self, request, queryset):
		if request.user.has_perm('radiograma.desactivar_parametro'):
			rows_updated = queryset.update(activo=False)
			if rows_updated == 1:
		    		message_bit = "1 registro esta"
			else:
		    		message_bit = "%s registros estan" % rows_updated
			self.message_user(request, "%s correctamente desactivados." % message_bit)
		else:
			raise PermissionDenied
	desactivar_registro.short_description = "Marcar registros como desactivados"
	

class TinajonesAdmin(admin.ModelAdmin):
	fieldsets = (
	(None, {
		'fields' : ('altura','area','volumen','factor',)
	}),
	('Opciones Avanzadas', {
		'classes':('collapse',),
		'fields': ('activo',)
	}),
	)
	list_display = ('altura','area','volumen','factor','activo',)
	search_fields = ('altura','area','volumen','factor','activo',)
        list_filter = ('activo','created_at','updated_at',)
	date_hierarchy = 'created_at'
	list_per_page = 15
        actions = ['activar_registro','desactivar_registro',]

	def save_model(self, request, obj, form, change): 
    		obj.ip_address =  request.META['REMOTE_ADDR'] 
		obj.host_name = request.META['REMOTE_HOST']
		obj.user = request.user
        	obj.save() 

	def activar_registro(self, request, queryset):
		if request.user.has_perm('radiograma.activar_tinajones'):
			rows_updated = queryset.update(activo=True)
			if rows_updated == 1:
		    		message_bit = "1 registro esta"
			else:
		    		message_bit = "%s registros estan" % rows_updated
			self.message_user(request, "%s correctamente activados." % message_bit)
		else:
			raise PermissionDenied

	activar_registro.short_description = "Marcar registros como activados"

	def desactivar_registro(self, request, queryset):
		if request.user.has_perm('radiograma.desactivar_tinajones'):
			rows_updated = queryset.update(activo=False)
			if rows_updated == 1:
		    		message_bit = "1 registro esta"
			else:
		    		message_bit = "%s registros estan" % rows_updated
			self.message_user(request, "%s correctamente desactivados." % message_bit)
		else:
			raise PermissionDenied
	desactivar_registro.short_description = "Marcar registros como desactivados"
	

class MedidasInline(admin.TabularInline):
	model = Medida
	fieldsets = (
	(None, {
	'fields' : 	('radiograma','parametro','hora1','hora2','hora3','hora4','hora5','hora6','hora8','hora9','hora10','hora11','hora12','hora13','hora14','hora15','hora16','hora17','hora18','hora19','hora20','hora21','hora22','hora23','hora24',)
	}),
	)
	extra = 1


class RadiogramaAdmin(admin.ModelAdmin):

	fieldsets = (
	(None, {
		'fields' : ('fecha','numero','observacion','activo',)
	}),


	('Reservorio', {
		'classes':('collapse',),
		'fields': ('reservorio_cota','reservorio_humedad_relativa','reservorio_temperatura_maxima','reservorio_temperatura_minima','reservorio_evaporacion','reservorio_precipitacion','reservorio_hora_precipitacion',)
	}),
	

	('Transvase Chotano', {
		'classes':('collapse',),
		'fields': ('trasvase_tunel_chotano','chotano_seishoras','chotano_temperatura_maxima','chotano_temperatura_mimino','chotano_humedad_relativa','chotano_precipitacion',)
	}),

	
	('Transvase Chonchano', {
		'classes':('collapse',),
		'fields': ('trasvase_tunel_chonchano','chonchano_seishoras','chotano_estado_tiempo',)
	}),
	


	('Temperatura Reservorio', {
		'classes':('collapse',),
		'fields': ('reservorio_temperatura_05horas','reservorio_temperatura_13horas','reservorio_temperatura_19horas',)
	}),
	)

	inlines = [MedidasInline,]
	list_display = ('fecha','numero','reservorio_volumen','perdidas',)
	search_fields = ('numero',)
	list_per_page = 10
	list_filter = ('activo','publicado','created_at','updated_at',)
	date_hierarchy = 'created_at'
        actions = ['activar_registro','desactivar_registro','publicar_registro','despublicar_registro',]
	
	def save_model(self, request, obj, form, change): 
    		obj.ip_address =  request.META['REMOTE_ADDR'] 
		obj.host_name = request.META['REMOTE_HOST']
		obj.user = request.user
        	obj.save() 

	def save_formset(self, request, form, formset, change):
		instances = formset.save(commit=False)
		for instance in instances:
		    instance.ip_address =  request.META['REMOTE_ADDR'] 
		    instance.host_name = request.META['REMOTE_HOST'] 
		    instance.user = request.user
		    instance.save()
		formset.save_m2m()

	def activar_registro(self, request, queryset):
		if request.user.has_perm('radiograma.activar_radiograma'):
			rows_updated = queryset.update(activo=True)
			if rows_updated == 1:
		    		message_bit = "1 registro esta"
			else:
		    		message_bit = "%s registros estan" % rows_updated
			self.message_user(request, "%s correctamente activados." % message_bit)
		else:
			raise PermissionDenied
	activar_registro.short_description = "Marcar registros como activados"

	def desactivar_registro(self, request, queryset):
		if request.user.has_perm('radiograma.desactivar_radiograma'):
			rows_updated = queryset.update(activo=False)
			if rows_updated == 1:
		    		message_bit = "1 registro esta"
			else:
		    		message_bit = "%s registros estan" % rows_updated
			self.message_user(request, "%s correctamente desactivados." % message_bit)
		else:
			raise PermissionDenied
	desactivar_registro.short_description = "Marcar registros como desactivados"

	def publicar_registro(self, request, queryset):
		if request.user.has_perm('radiograma.publicar_radiograma'):
			rows_updated = queryset.update(publicado=True)
			if rows_updated == 1:
		    		message_bit = "1 registro esta"
			else:
		    		message_bit = "%s registros estan" % rows_updated
			self.message_user(request, "%s correctamente publicados." % message_bit)
		else:
			raise PermissionDenied
	publicar_registro.short_description = "Marcar registros como publicados"


	def despublicar_registro(self, request, queryset):
		if request.user.has_perm('radiograma.despublicar_radiograma'):
			rows_updated = queryset.update(publicado=False)
			if rows_updated == 1:
		    		message_bit = "1 registro esta"
			else:
		    		message_bit = "%s registros estan" % rows_updated
			self.message_user(request, "%s correctamente despublicados." % message_bit)
		else:
			raise PermissionDenied
	despublicar_registro.short_description = "Marcar registros como despublicados"


admin.site.register(Parametro,ParametroAdmin)
admin.site.register(Tinajones,TinajonesAdmin)
admin.site.register(Radiograma,RadiogramaAdmin)
