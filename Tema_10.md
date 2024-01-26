Răspundeți la următoarele întrebări:
• Care este rolul comenzilor GL.Push() și GL. Pop()? De ce este necesară utilizarea lor?
 GL.Push() plasează o copie a matricei de transformare curentă pe stivă.
 GL.Pop() scoate matricea de transformare din partea de sus a stivei și o restabilește ca matrice curentă.
 Aceste comenzi ajută la salvarea și restabilirea stării matricei de transformare, permițând programatorilor să aplice transformări locale fără a afecta transformările globale.

• Explicați efectul rulării metodelor GL.Rotate(), GL.Translate() și GL.Scale(). Furnizați câte un exemplu comentat!
GL.Rotate() - Rotește obiectul curent cu unghiul specificat (în grade) în jurul unei axe predefinite de un vector.
GL.Rotate(mousePos.X, 1, 0, 0); //obiectul se va roti in functie de pozitia mouse-ului

GL.Translate() - Deplaseaza obiectul curent în spațiul 3D folosind valorile  x, y, z specificate.
GL.Translate(1.0f + translateTriangleVal, 1.0f + translateTriangleVal, 1.0f + translateTriangleVal); //obiectul va fi deplasat cu (1,1,1) fata de pozitia initiala

GL.Scale()- Modifica dimensiunile obiectul curent cu factorul specificat în  x, y, z
GL.Scale(2.0f, 2.0f, 2.0f); //modifica obiectul la dimensiunile (2,2,2)

• Câte nivele de manipulări ierarhice (folosindu-se GL.Push()/GL.Pop()) suportă o scenă OpenGL?
Numărul de nivele ierarhice de operațiuni pe care le acceptă o scenă OpenGL (folosind GL.Push() și GL.Pop())  nu este menționat în mod explicit în specificația OpenGL.