1.
La modificarea constantei „MatrixMode.Projection” se observă că figura își modifică
poziționarea în fereastra.
3.
⚫Ce este un viewport?
Viewport-ul este zona vizibilă a utilizatorului unei pagini web. Aceasta este exprimată în coordonate specifice randamentului, adică pixeli ce reprezintă coordonatele ecranului pe care obiectele vor fi afișate.
⚫ Ce reprezintă conceptul de frames per seconds din punctul de vedere al bibliotecii OpenGL?
FPS(frames per seconds) este frecvența la  care imaginile consecutive numite cadre apar pe ecran.
⚫ Când este rulată metoda OnUpdateFrame()?
Metoda OnUpdateFrame() este rulată automat pe ecran în pasul următor, când va fi realizată următoarea randare - control utilizator, actualizarea poziției obiectelor, etc. 
⚫ Ce este modul imediat de randare?
Modul imediat de randare este un stil de programare al aplicațiilor pentru interfețele din bibliotecile de grafică. În acest mod utilizatorul apelează direct la afișarea obiectelor grafice pe ecran  sau datele care descriu primitivele de redare sunt inserate frame by frame direct într-o  listă de comenzi.
⚫ Care este ultima versiune de OpenGL care acceptă modul imediat?
Ultima versiune de OpenGL care acceptă modul imediat este OpenGL 4.8. 
⚫ Când este rulată metoda OnRenderFrame()?
Metoda OnRenderFrame () este rulată atunci când se dorește randarea scenei grafice. 
⚫ De ce este nevoie ca metoda OnResize() să fie executată cel puțin o dată?
Metoda OnResize() trebuie execută măcar odată pentru inițierea afișării și setarea
viewport-ului grafic.
⚫ Ce reprezintă parametrii metodei CreatePerspectiveFieldOfView() și care este domeniul de valori pentru aceștia?
Parametrii metodei CreatePerspectiveFieldOfView() reprezintă crearea unei perspective  a proiectării unei matrici sau a raportului de aspecte și distanțe plane apropiate și de vedere.