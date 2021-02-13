hada-p1
Nicolás Van Olmen Giménez
P1: -n significa “don’t automatically commit”, o sea que no hace el commit automáticamente.
P2: Todo ha vuelto al estado del último commit.
P3: Reset te permite volver al estado del último commit ignorando todos los cambios que hayas hecho y no genera un nuevo commit al resetear. En cambio revert te permite volver al estado de cualquier commit anterior(indicándole el hash del commit) y genera un nuevo commit en el log. 
P4: Merge une directamente las ramas indicadas, mientras que rebase unifica todo en una rama poniendo al final los cambios desde la rama desde donde se llama hasta la otra. Por ello, al usar rebase el log no queda ordenado de forma cronológica, sin embargo con merge sí ya que te guarda las bifurcaciones entre las ramas.

