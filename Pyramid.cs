using System;
					
public class Program
{
	public static void Main(String[] args)
	{
			marioPyramid(5);
			oppositePyramid(5);	
			Pyramid(5);
			
		}
	
		
		public static void marioPyramid(int height){
				
		for (int row = 1; row<=height; row++){
			
			for(int space = row; space <= height; space++){
				Console.Write(" ");
				
				
			}
			for (int star = 1; star <= row; star++){
				
			Console.Write("*");	
			}
			Console.WriteLine();
			
		}
				
		}
	public static void oppositePyramid(int height){
		
		for (int row = 1; row <= height; row++ ){
		
			for(int space = 5; space <= height; space++){
				Console.Write(" ");
				
			}
			for(int star = 1; star <= row; star++){
			Console.Write("*");	
				
			}
		
			
			Console.WriteLine();
			
		}
			
			
		}
	
	public static void Pyramid (int height){
	
		for(int row = 1; row <= height; row++){
			for(int space = row; space <= height; space++){
				Console.Write(" ");
				
				
			}
			for (int star = 1; star <= row*2-1; star++){
				
			Console.Write("*");	
			}
			Console.WriteLine();
			
			
			
		}
		
	}
		
		
		
	}
		
		