from django.conf.urls import patterns, include, url
from django.conf.urls.defaults import patterns, include, url
from django.conf.urls.defaults import *
from infraestructura.views import *

from django.contrib import admin
admin.autodiscover()


urlpatterns = patterns('',
    url(r'^admin/', include(admin.site.urls)),
    url(r'^site_media/(?P<path>.*)$', 'django.views.static.serve', {'document_root': '/home/erick/Dropbox/Django/Inventario/media'}),
    url(r'^categoria/(\d+)/$', 'infraestructura.views.categoria'),
    url(r'^tipo/(\d+)/$', 'infraestructura.views.tipo'),
    url(r'^/?$', 'infraestructura.views.index'),
)
