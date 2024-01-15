6. Răspundeți la următoarele întrebări:
o Descrieți diferențele dintre iluminarea așa cum funcționează în lumea reală și modelul de iluminare utilizat de OpenGL.
Atunci când observați o suprafață fizică, percepția culorii de către ochi depinde de modul în care energiile fotonice sunt distribuite și activează celulele conului. Acești fotoni provin de la o sursă de lumină sau o combinație de surse, fiind absorbiți sau reflectați de suprafață. De asemenea, proprietățile suprafeței pot varia semnificativ - unele sunt strălucitoare și reflectă lumina în anumite direcții, în timp ce altele difuzează lumina uniform în toate direcțiile. Cele mai multe suprafețe se află undeva între aceste extreme.
OpenGL modelează lumină și iluminare considerând că lumina poate fi descompusă în componente roșii, verzi și albastre. Prin urmare, culoarea surselor de lumină este caracterizată de cantitatea de lumină roșie, verde și albastră pe care o emit, în timp ce materialul suprafeței este definit de procentul componentelor roșii, verzi și albastre care sunt reflectate în diverse direcții.

o Câte surse de lumină sunt suportate în implementarea curentă a OpenGL cu ajutorul framework-ului OpenTK?
OpenGL cu ajutorul framework-ului OpenTK suportă trei surse de lumină și acestea sunt: 
Lumină ambientală
Lumină difuză
Lumină speculară


o Definiți iluminarea de material și specificați unde și când este utilizată aceasta.
Iluminare de material înseamnă simularea reflexiei și a transmisiei luminii ţinând cont de proprietăţile materialelor fiind utilizată pentru a creea o imagine a obiectului cât mai aproape de realitate. 

o Care este efectul asupra diverselor obiecte la activarea unei surse de lumină secundare (per pct. 3), comparativ cu utilizarea unei singure surse de lumină?
La activarea unei surse de lumină secundare pe lângă sursa principal are ca efect accentuarea unor porțiuni din obiecte dând dinamism scenei.
