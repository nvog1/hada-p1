# hada-p1
#Nicolás Van Olmen Giménez, 74383864R
P1: Se ha subido la rama master.

P2: Se muestra una vista de los dos documentos, el antiguo en la izquierda y el nuevo en la derecha, con las líneas que cambian entre ellos resaltadas. En verde aparecen adiciones y en rojo borrados.

P3: No ha habido ningún cambio en el repositorio remoto, pues había conflictos y no me ha dejado hacer la inserción. Los conflictos han sido generados porque la rama master local no coincide con la versión de la rama master remota, pues en la remota hay una versión más, en la que añadimos el README.md.

P4:’Confirmar todo’ provoca que todos los cambios desde el último commit(estén o no estén en el staging area) se incluyan en un commit.
El comando equivalente sería: git commit -a [-m “Mensaje del commit”]

P5:’Confirmar todo e insertar’ hace un commit con todo el working area y luego lo inserta en el repositorio remoto. El equivalente en git sería:
>git commit -a
>git push

P6:’Confirmar todo y sincronizar’ hace un commit de todo el working area y luego sincroniza con el repositorio remoto. El equivalente en git sería:
>git commit -a
>git pull -u <url del repo> nombre_rama

P7: Extraer hace un merge de lo que hay en el remoto con lo que tengo en local. El equivalente en git sería:
>git pull
>git checkout master
>git merge -u origin/master

Sincronizar hace lo mismo pero además luego el resultado lo inserta en el repo remoto. El equivalente en git sería:
>git pull
>git checkout master
>git merge origin/master
>git push -u <url repo remoto> master

