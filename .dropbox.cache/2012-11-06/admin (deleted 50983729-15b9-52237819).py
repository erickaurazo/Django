# -*- encoding: utf-8 -*-
from django.contrib import admin
from infraestructura.models import *
from django.core.exceptions import PermissionDenied


class CategoriaAdmin(admin.ModelAdmin):
	fieldsets = (
	(None, {
		'fields' : ('nombre','activo',)
		}
	),
	
	)	
	list_display = ('nombre','activo',)
	search_fields = ('nombre',)
	list_per_page = 10
	list_filter = ('activo','created_at','updated_at',)
	date_hierarchy = 'created_at'
	
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


class AreaAdmin(admin.ModelAdmin):
	fieldsets = (
	(None, {
		'fields' : ('nombre','activo',)
		}
	),
	
	)	
	list_display = ('nombre','activo',)
	search_fields = ('nombre',)
	list_per_page = 10
	list_filter = ('activo','created_at','updated_at',)
	date_hierarchy = 'created_at'
	
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

class PersonaAdmin(admin.ModelAdmin):

	fieldsets = (
	(None, {
		'fields' : ('nombre','apellidos','area','activo',)
		}
	),
	
	)	
	list_display = ('nombre','apellidos','area','activo',)
	search_fields = ('nombre',)
	list_per_page = 10
	list_filter = ('area','activo','created_at','updated_at',)
	date_hierarchy = 'created_at'
	
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


class TipoAdmin(admin.ModelAdmin):
	fieldsets = (
	(None, {
		'fields' : ('nombre','categoria','descripcion','abreviatura',)

	}),
	('Opciones Avanzadas', {
		'classes':('collapse',),
		'fields': ('activo',)
	}),
	)
	list_display = ('nombre','categoria','descripcion','abreviatura','activo',)
	search_fields = ('nombre',)
        list_filter = ('categoria','activo','created_at','updated_at',)
	date_hierarchy = 'created_at'
	list_per_page = 10

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


class DetalleInline(admin.TabularInline):
	model = Detalle
	fieldsets = (
	(None, {
	'fields' : 	('dispositivo','tipo','fechaCompra','marca','modelo','serie','garantia','capacidad','version','numeroLicencias','descripcion','activo',)
	}),
	)
	extra = 1
	
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

class DispositivoAdmin(admin.ModelAdmin):

	fieldsets = (
	(None, {
		'fields' : ('nombre','fechaIngreso','fechaSalida',)
		}
	),

	('comprobantes', {
		'classes':('collapse',),
		'fields': ('comprobante','persona','activo',)
	}),	
	)

	inlines = [DetalleInline,]
	list_display = ('nombre','persona','fechaIngreso','fechaSalida','comprobante','activo',)
	search_fields = ('nombre',)
	list_per_page = 10
	list_filter = ('persona','activo','updated_at',)
	date_hierarchy = 'created_at'
	
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



admin.site.register(Categoria,CategoriaAdmin)
admin.site.register(Area,AreaAdmin)
admin.site.register(Persona,PersonaAdmin)
admin.site.register(Tipo,TipoAdmin)
admin.site.register(Dispositivo,DispositivoAdmin)

