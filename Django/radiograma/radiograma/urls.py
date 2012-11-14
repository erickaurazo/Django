from django.conf.urls import patterns, include, url
from django.conf.urls.defaults import patterns, include, url
from hidrologia.views import *
# Uncomment the next two lines to enable the admin:
from django.contrib import admin
admin.autodiscover()

urlpatterns = patterns('',
      url(r'^admin/', include(admin.site.urls)),
    # url(r'^radiograma_presidentePDF/$', radiograma_pdf),
      url(r'^reporte_radiograma_usuariosPDF/$', reporte_radiograma_usuarios_pdf),
      url(r'^reporte_radiograma_presidentePDF/$', reporte_radiograma_presidente_pdf),
      url(r'^medidas_diariasPDF/$', medidas_pdf),
      url(r'^balance_radiograma_diarioPDF/$', balance_pdf),
      url(r'^consolidado_mensual_medidasPDF/$', consolidado_medidas_mensual_pdf),
      url(r'^consolidado_mensual_radiogramasPDF/$', consolidado_radiograma_mensual_pdf),
      url(r'^consolidado_mensual_chonchanoPDF/$', consolidado_mensual_chonchano_pdf),
      url(r'^consolidado_mensual_chotanoPDF/$', consolidado_mensual_chotano_pdf),
      url(r'^consolidado_mensual_chancay/$', consolidado_mensual_chancay_pdf),
      url(r'^consolidado_mensual_hidrometria_sistema_mayorPDF/$', consolidado_mensual_hidrometria_sistema_mayor_pdf),
      url(r'^consolidado_informacion_tinajonesPDF/$', consolidado_informacion_tinajones_pdf),
      url(r'^site_media/(?P<path>.*)$', 'django.views.static.serve', {'document_root': '/home/erick/Dropbox/radiograma/media'}),
      url(r'^radiograma/(\d+)/$', 'hidrologia.views.radiograma'),
      url(r'^/?$', 'hidrologia.views.index'),

)
