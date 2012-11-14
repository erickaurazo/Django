from django.db import models
from django.forms import TextInput

class MyFloatField(models.FloatField):
    def formfield(self, **kwargs):
         kwargs.update(
            {"widget": TextInput(attrs={'size': 6})}
         )
         return super(MyFloatField, self).formfield(**kwargs)

