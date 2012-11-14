from django.conf.urls import patterns, include, url
from django.conf.urls.defaults import *

from django.contrib import admin
admin.autodiscover()

urlpatterns = patterns('',
    (r'^admin/', include(admin.site.urls)),
    (r'^site_media/(?P<path>.*)$', 'django.views.static.serve', {'document_root': '/home/erick/Dropbox/Instituto/media'}),
    (r'^instituto/(\d+)/$', 'gestion.views.instituto'),
    (r'^grupo/(\d+)/$', 'gestion.views.grupo'),
    (r'^/?$', 'gestion.views.index'),
)
