package salle2;

public class Main {

	public static void main(String[] args) {
		
		Forme[] tableau = new Forme[5];
		
		Rectangle f = new Rectangle(1,1);
		Carre f2 = new Carre(1,1);
		Cercle f3 = new Cercle(1,1);
		Triangle f4 = new TriangleRect(1,1);
		Triangle f5 = new TriangleIso(1,1);
		
		tableau[0] = f;
		tableau[1] = f2;
		tableau[2] = f3;
		tableau[3] = f4;
		tableau[4] = f5;
		
		for(int i =0 ; i < tableau.length ; i++) {
			try {
				// ICI CE SONT LES ACTIONS DU JOUEURS
				((Rectangle) tableau[i]).deplacerRectangle(1,1);
				
			}catch(Exception e) {
				System.out.println(e);
			}
		}
		for(int i =0 ; i < tableau.length ; i++) {
			try {
				// ICI CE SONT LES ACTIONS DU JOUEURS
				((Rectangle) tableau[i]).deplacerRectangle(1,1);
				
			}catch(Exception e) {
				System.out.println(e);
			}
		}
		for(int i =0 ; i < tableau.length ; i++) {
			try {
				// ICI CE SONT LES ACTIONS DU JOUEURS
				((Triangle) tableau[i]).deplacerTriangle(1,1);
				
			}catch(Exception e) {
				System.out.println(e);
			}
		}
		for(int i =0 ; i < tableau.length ; i++) {
			try {
				// ICI CE SONT LES ACTIONS DU JOUEURS
				((TriangleIso) tableau[i]).deplacerTriangleIso(1,1);
				
			}catch(Exception e) {
				System.out.println(e);
			}
		}
		for(int i =0 ; i < tableau.length ; i++) {
			try {
				// ICI CE SONT LES ACTIONS DU JOUEURS
				((Carre) tableau[i]).deplacerCarre(1,1);
				
			}catch(Exception e) {
				System.out.println(e);
			}
		}
		
		for(int i =0 ; i < tableau.length ; i++) {
			System.out.println(tableau[i].x + " " + tableau[i].y);
		}
		
//		f.deplacerRectangle(1, 1);
//		System.out.println(f.x + " " + f.y);
	}

}

	