/*
 * Created by SharpDevelop.
 * User: RM20222930026
 * Date: 15/08/2022
 * Time: 13:19
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CAVALO2._
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		string palavra;
		int contErros = 0;
		
		void Button1Click(object sender, EventArgs e)
		{
			//char letra = 'A';
			//string s = textBox1.Text;
			//int cont = 0;
			//for (int pos = 0; pos < s.Length; pos++)
			//{
			//	if (letra == s[pos])
			//		cont++;
					
			//}
			//	
			//label1.Text = "A letra " + letra + " aparece " + cont + " vezes";
			//if (cont == 0)
			//	MessageBox.Show("Você errou");
			//else
			//MessageBox.Show("Você acertou, parabéns!");
		}
		void Button2Click(object sender, EventArgs e)
		{
			palavra = textBox1.Text;
			string aux = "";
			for (int i=0; i< palavra.Length; i++)
			{
				aux += "?";
			}
			label2.Text = aux; 
			textBox1.Visible = false;
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			//button1.Enabled = false;
			Button bt = (sender as Button); 
			char letra = bt. Text [0];
			int cont = 0; 
			string aux = ""; 
			for (int pos = 0; pos < palavra.Length; pos++)
			{
				if (letra == palavra[pos])
				{	
					cont++;
					aux += letra;
				}
				else	
				{
					aux += label2.Text[pos];
				}
			}
			
			label2.Text = aux; 
			if (cont == 0) 
			{
				contErros++;
				bt.BackColor = Color.Red; 
				pictureBox1.Load("forca" + contErros +".png");
				if (contErros == 7)
				{
					panel1.Enabled = false;
					MessageBox.Show("Perdeu, Pureibói");
					button25.Visible = true;
				}
			}
			else
			{
				//button29.BackColor = Color.LightGreen;
				bt.BackColor = Color.LightGreen;
				if (label2.Text == palavra)
				{
					panel1.Enabled = false;
					pictureBox2.Visible = true;
					
					MessageBox.Show ("Parabuenas MUCHACHO, you win!!");
						
					button25.Visible = true;
					pictureBox2.Visible = false;
			}
			}
		}
		

	
		void Button6Click(object sender, EventArgs e)
		{
			contErros++;
			this.Text = "Erros: " + contErros;
			pictureBox1.Load ("Forca"+contErros+".png");
		}
		void PictureBox1Click(object sender, EventArgs e)
		{
			
		}
		
//		VERSÃO EXTENSA DO CÓDIGO DO JOGO DA FORCA
		
		/*void Button8Click(object sender, EventArgs e)
		{
			char letra = 'E'; 
			int cont = 0; 
			string aux = ""; 
			for (int pos = 0; pos < palavra.Length; pos++)
			{
				if (letra == palavra[pos])
				{	
					cont++;
					aux += letra;
				}
				else	
				{
					aux += label2.Text[pos];
				}
			}
			
			label2.Text = aux; 
			if (cont == 0) 
			{
				contErros++;
				button8.BackColor = Color.Red;
				pictureBox1.Load("forca" + contErros +".png");
				if (contErros == 7)
				{
					panel1.Enabled = false;
					MessageBox.Show("Perdeu, Pureibói");
					button25.Visible = true;
				}
			}
			else
			{
				//button29.BackColor = Color.LightGreen;
				button8.BackColor = Color.LightGreen;
				if (label2.Text == palavra)
				{
					panel1.Enabled = false;
					pictureBox2.Visible = true;
					
					MessageBox.Show ("Parabuenas MUCHACHO, you win!!");
						
					button25.Visible = true;
					pictureBox2.Visible = false;
			}
			}
			}
			void Button7Click(object sender, EventArgs e)
		{
			char letra = 'D'; 
			int cont = 0; 
			string aux = ""; 
			for (int pos = 0; pos < palavra.Length; pos++)
			{
				if (letra == palavra[pos])
				{	
					cont++;
					aux += letra;
				}
				else	
				{
					aux += label2.Text[pos];
				}
			}
			
			label2.Text = aux; 
			if (cont == 0) 
			{
				contErros++;
				button7.BackColor = Color.Red;
				pictureBox1.Load("forca" + contErros +".png");
				if (contErros == 7)
				{
					panel1.Enabled = false;
					MessageBox.Show("Perdeu, Pureibói");
					button25.Visible = true;
				}
			}
			else
			{
				//button29.BackColor = Color.LightGreen;
				button7.BackColor = Color.LightGreen;
				if (label2.Text == palavra)
				{
					panel1.Enabled = false;
					pictureBox2.Visible = true;
					
					MessageBox.Show ("Parabuenas MUCHACHO, you win!!");
						
					button25.Visible = true;
					pictureBox2.Visible = false;
			}
			}
		}*/
		/*void Button9Click(object sender, EventArgs e)
		{
			char letra = 'F'; 
			int cont = 0; 
			string aux = ""; 
			for (int pos = 0; pos < palavra.Length; pos++)
			{
				if (letra == palavra[pos])
				{	
					cont++;
					aux += letra;
				}
				else	
				{
					aux += label2.Text[pos];
				}
			}
			label2.Text = aux; 
			if (cont == 0) 
			{
				contErros++;
				button9.BackColor = Color.Red;
				pictureBox1.Load("forca" + contErros +".png");
				if (contErros == 7)
				{
					panel1.Enabled = false;
					MessageBox.Show("Perdeu, Pureibói");
					button25.Visible = true;
				}
			}
			else
			{
				//button29.BackColor = Color.LightGreen;
				button9.BackColor = Color.LightGreen;
				if (label2.Text == palavra)
				{
					panel1.Enabled = false;
					pictureBox2.Visible = true;
					
					MessageBox.Show ("Parabuenas MUCHACHO, you win!!");
						
					button25.Visible = true;
					pictureBox2.Visible = false;
			}
			}
		}
		void Button10Click(object sender, EventArgs e)
		{
			char letra = 'G'; 
			int cont = 0; 
			string aux = ""; 
			for (int pos = 0; pos < palavra.Length; pos++)
			{
				if (letra == palavra[pos])
				{	
					cont++;
					aux += letra;
				}
				else	
				{
					aux += label2.Text[pos];
				}
			}
			
			label2.Text = aux; 
			if (cont == 0) 
			{
				contErros++;
				button10.BackColor = Color.Red;
				pictureBox1.Load("forca" + contErros +".png");
				if (contErros == 7)
				{
					panel1.Enabled = false;
					MessageBox.Show("Perdeu, Pureibói");
					button25.Visible = true;
				}
			}
			else
			{
				//button29.BackColor = Color.LightGreen;
				button10.BackColor = Color.LightGreen;
				if (label2.Text == palavra)
				{
					panel1.Enabled = false;
					pictureBox2.Visible = true;
					
					MessageBox.Show ("Parabuenas MUCHACHO, you win!!");
						
					button25.Visible = true;
					pictureBox2.Visible = false;
			}
			}
		}
		void Button22Click(object sender, EventArgs e)
		{
			char letra = 'H'; 
			int cont = 0; 
			string aux = ""; 
			for (int pos = 0; pos < palavra.Length; pos++)
			{
				if (letra == palavra[pos])
				{	
					cont++;
					aux += letra;
				}
				else	
				{
					aux += label2.Text[pos];
				}
			}
			
		label2.Text = aux; 
			if (cont == 0) 
			{
				contErros++;
				button22.BackColor = Color.Red; 
				pictureBox1.Load("forca" + contErros +".png");
				if (contErros == 7)
				{
					panel1.Enabled = false;
					MessageBox.Show("Perdeu, Pureibói");
					button25.Visible = true;
				}
			}
			else
			{
				//button29.BackColor = Color.LightGreen;
				button22.BackColor = Color.LightGreen;
				if (label2.Text == palavra)
				{
					panel1.Enabled = false;
					pictureBox2.Visible = true;
					
					MessageBox.Show ("Parabuenas MUCHACHO, you win!!");
						
					button25.Visible = true;
					pictureBox2.Visible = false;
			}
			}
		}
		void Button11Click(object sender, EventArgs e)
		{
			char letra = 'I'; 
			int cont = 0; 
			string aux = ""; 
			for (int pos = 0; pos < palavra.Length; pos++)
			{
				if (letra == palavra[pos])
				{	
					cont++;
					aux += letra;
				}
				else	
				{
					aux += label2.Text[pos];
				}
			}
			
			label2.Text = aux; 
			if (cont == 0) 
			{
				contErros++;
				button11.BackColor = Color.Red; 
				pictureBox1.Load("forca" + contErros +".png");
				if (contErros == 7)
				{
					panel1.Enabled = false;
					MessageBox.Show("Perdeu, Pureibói");
					button25.Visible = true;
				}
			}
			else
			{
				//button29.BackColor = Color.LightGreen;
				button11.BackColor = Color.LightGreen;
				if (label2.Text == palavra)
				{
					panel1.Enabled = false;
					pictureBox2.Visible = true;
					
					MessageBox.Show ("Parabuenas MUCHACHO, you win!!");
						
					button25.Visible = true;
					pictureBox2.Visible = false;
			}
			}
		}
		void Button12Click(object sender, EventArgs e)
		{
			char letra = 'J'; 
			int cont = 0; 
			string aux = ""; 
			for (int pos = 0; pos < palavra.Length; pos++)
			{
				if (letra == palavra[pos])
				{	
					cont++;
					aux += letra;
				}
				else	
				{
					aux += label2.Text[pos];
				}
			}
			
			label2.Text = aux; 
			if (cont == 0) 
			{
				contErros++;
				button12.BackColor = Color.Red; 
				pictureBox1.Load("forca" + contErros +".png");
				if (contErros == 7)
				{
					panel1.Enabled = false;
					MessageBox.Show("Perdeu, Pureibói");
					button25.Visible = true;
				}
			}
			else
			{
				//button29.BackColor = Color.LightGreen;
				button12.BackColor = Color.LightGreen;
				if (label2.Text == palavra)
				{
					panel1.Enabled = false;
					pictureBox2.Visible = true;
					
					MessageBox.Show ("Parabuenas MUCHACHO, you win!!");
						
					button25.Visible = true;
					pictureBox2.Visible = false;
			}
			}
		}
		void Button13Click(object sender, EventArgs e)
		{
			char letra = 'K'; 
			int cont = 0; 
			string aux = ""; 
			for (int pos = 0; pos < palavra.Length; pos++)
			{
				if (letra == palavra[pos])
				{	
					cont++;
					aux += letra;
				}
				else	
				{
					aux += label2.Text[pos];
				}
			}
			
			label2.Text = aux; 
			if (cont == 0) 
			{
				contErros++;
				button13.BackColor = Color.Red;
				pictureBox1.Load("forca" + contErros +".png");
				if (contErros == 7)
				{
					panel1.Enabled = false;
					MessageBox.Show("Perdeu, Pureibói");
					button25.Visible = true;
				}
			}
			else
			{
				//button29.BackColor = Color.LightGreen;
				button13.BackColor = Color.LightGreen;
				if (label2.Text == palavra)
				{
					panel1.Enabled = false;
					pictureBox2.Visible = true;
					
					MessageBox.Show ("Parabuenas MUCHACHO, you win!!");
						
					button25.Visible = true;
					pictureBox2.Visible = false;
			}
			}
		}
		void Button14Click(object sender, EventArgs e)
		{
			char letra = 'L'; 
			int cont = 0; 
			string aux = ""; 
			for (int pos = 0; pos < palavra.Length; pos++)
			{
				if (letra == palavra[pos])
				{	
					cont++;
					aux += letra;
				}
				else	
				{
					aux += label2.Text[pos];
				}
			}
			
		label2.Text = aux; 
			if (cont == 0) 
			{
				contErros++;
				button14.BackColor = Color.Red; 
				pictureBox1.Load("forca" + contErros +".png");
				if (contErros == 7)
				{
					panel1.Enabled = false;
					MessageBox.Show("Perdeu, Pureibói");
					button25.Visible = true;
				}
			}
			else
			{
				//button29.BackColor = Color.LightGreen;
				button14.BackColor = Color.LightGreen;
				if (label2.Text == palavra)
				{
					panel1.Enabled = false;
					pictureBox2.Visible = true;
					
					MessageBox.Show ("Parabuenas MUCHACHO, you win!!");
						
					button25.Visible = true;
					pictureBox2.Visible = false;
			}
			}
		}
		void Button15Click(object sender, EventArgs e)
		{
			char letra = 'M'; 
			int cont = 0; 
			string aux = ""; 
			for (int pos = 0; pos < palavra.Length; pos++)
			{
				if (letra == palavra[pos])
				{	
					cont++;
					aux += letra;
				}
				else	
				{
					aux += label2.Text[pos];
				}
			}
			
			label2.Text = aux; 
			if (cont == 0) 
			{
				contErros++;
				button15.BackColor = Color.Red; 
				pictureBox1.Load("forca" + contErros +".png");
				if (contErros == 7)
				{
					panel1.Enabled = false;
					MessageBox.Show("Perdeu, Pureibói");
					button25.Visible = true;
				}
			}
			else
			{
				//button29.BackColor = Color.LightGreen;
				button15.BackColor = Color.LightGreen;
				if (label2.Text == palavra)
				{
					panel1.Enabled = false;
					pictureBox2.Visible = true;
					
					MessageBox.Show ("Parabuenas MUCHACHO, you win!!");
						
					button25.Visible = true;
					pictureBox2.Visible = false;
			}
			}
		}
		void Button16Click(object sender, EventArgs e)
		{
			char letra = 'N'; 
			int cont = 0; 
			string aux = ""; 
			for (int pos = 0; pos < palavra.Length; pos++)
			{
				if (letra == palavra[pos])
				{	
					cont++;
					aux += letra;
				}
				else	
				{
					aux += label2.Text[pos];
				}
			}
			
			label2.Text = aux; 
			if (cont == 0) 
			{
				contErros++;
				button16.BackColor = Color.Red;
				pictureBox1.Load("forca" + contErros +".png");
				if (contErros == 7)
				{
					panel1.Enabled = false;
					MessageBox.Show("Perdeu, Pureibói");
					button25.Visible = true;
				}
			}
			else
			{
				//button29.BackColor = Color.LightGreen;
				button16.BackColor = Color.LightGreen;
				if (label2.Text == palavra)
				{
					panel1.Enabled = false;
					pictureBox2.Visible = true;
					
					MessageBox.Show ("Parabuenas MUCHACHO, you win!!");
						
					button25.Visible = true;
					pictureBox2.Visible = false;
			}
			}
		}
		void Button23Click(object sender, EventArgs e)
		{
			char letra = 'O'; 
			int cont = 0; 
			string aux = ""; 
			for (int pos = 0; pos < palavra.Length; pos++)
			{
				if (letra == palavra[pos])
				{	
					cont++;
					aux += letra;
				}
				else	
				{
					aux += label2.Text[pos];
				}
			}
			
			label2.Text = aux; 
			if (cont == 0) 
			{
				contErros++;
				button23.BackColor = Color.Red;
				pictureBox1.Load("forca" + contErros +".png");
				if (contErros == 7)
				{
					panel1.Enabled = false;
					MessageBox.Show("Perdeu, Pureibói");
					button25.Visible = true;
				}
			}
			else
			{
				//button29.BackColor = Color.LightGreen;
				button23.BackColor = Color.LightGreen;
				if (label2.Text == palavra)
				{
					panel1.Enabled = false;
					pictureBox2.Visible = true;
					
					MessageBox.Show ("Parabuenas MUCHACHO, you win!!");
						
					button25.Visible = true;
					pictureBox2.Visible = false;
			}
			}
		}
		void Button17Click(object sender, EventArgs e)
		{
			char letra = 'P'; 
			int cont = 0; 
			string aux = ""; 
			for (int pos = 0; pos < palavra.Length; pos++)
			{
				if (letra == palavra[pos])
				{	
					cont++;
					aux += letra;
				}
				else	
				{
					aux += label2.Text[pos];
				}
			}
			
			label2.Text = aux; 
			if (cont == 0) 
			{
				contErros++;
				button17.BackColor = Color.Red;
				pictureBox1.Load("forca" + contErros +".png");
				if (contErros == 7)
				{
					panel1.Enabled = false;
					MessageBox.Show("Perdeu, Pureibói");
					button25.Visible = true;
				}
			}
			else
			{
				//button29.BackColor = Color.LightGreen;
				button17.BackColor = Color.LightGreen;
				if (label2.Text == palavra)
				{
					panel1.Enabled = false;
					pictureBox2.Visible = true;
					
					MessageBox.Show ("Parabuenas MUCHACHO, you win!!");
						
					button25.Visible = true;
					pictureBox2.Visible = false;
			}
			}
		}
		void Button19Click(object sender, EventArgs e)
		{
			char letra = 'Q'; 
			int cont = 0; 
			string aux = ""; 
			for (int pos = 0; pos < palavra.Length; pos++)
			{
				if (letra == palavra[pos])
				{	
					cont++;
					aux += letra;
				}
				else	
				{
					aux += label2.Text[pos];
				}
			}
			
			label2.Text = aux; 
			if (cont == 0) 
			{
				contErros++;
				button19.BackColor = Color.Red;
				pictureBox1.Load("forca" + contErros +".png");
				if (contErros == 7)
				{
					panel1.Enabled = false;
					MessageBox.Show("Perdeu, Pureibói");
					button25.Visible = true;
				}
			}
			else
			{
				//button29.BackColor = Color.LightGreen;
				button19.BackColor = Color.LightGreen;
				if (label2.Text == palavra)
				{
					panel1.Enabled = false;
					pictureBox2.Visible = true;
					
					MessageBox.Show ("Parabuenas MUCHACHO, you win!!");
						
					button25.Visible = true;
					pictureBox2.Visible = false;
			}
			}
		}
		void Button18Click(object sender, EventArgs e)
		{
			char letra = 'R'; 
			int cont = 0; 
			string aux = ""; 
			for (int pos = 0; pos < palavra.Length; pos++)
			{
				if (letra == palavra[pos])
				{	
					cont++;
					aux += letra;
				}
				else	
				{
					aux += label2.Text[pos];
				}
			}
			
			label2.Text = aux; 
			if (cont == 0) 
			{
				contErros++;
				button18.BackColor = Color.Red;
				pictureBox1.Load("forca" + contErros +".png");
				if (contErros == 7)
				{
					panel1.Enabled = false;
					MessageBox.Show("Perdeu, Pureibói");
					button25.Visible = true;
				}
			}
			else
			{
				//button29.BackColor = Color.LightGreen;
				button18.BackColor = Color.LightGreen;
				if (label2.Text == palavra)
				{
					panel1.Enabled = false;
					pictureBox2.Visible = true;
					
					MessageBox.Show ("Parabuenas MUCHACHO, you win!!");
						
					button25.Visible = true;
					pictureBox2.Visible = false;
			}
			}
		}
		void Button20Click(object sender, EventArgs e)
		{
			char letra = 'S'; 
			int cont = 0; 
			string aux = ""; 
			for (int pos = 0; pos < palavra.Length; pos++)
			{
				if (letra == palavra[pos])
				{	
					cont++;
					aux += letra;
				}
				else	
				{
					aux += label2.Text[pos];
				}
			}
			
			label2.Text = aux; 
			if (cont == 0) 
			{
				contErros++;
				button20.BackColor = Color.Red;
				pictureBox1.Load("forca" + contErros +".png");
				if (contErros == 7)
				{
					panel1.Enabled = false;
					MessageBox.Show("Perdeu, Pureibói");
					button25.Visible = true;
				}
			}
			else
			{
				//button29.BackColor = Color.LightGreen;
				button20.BackColor = Color.LightGreen;
				if (label2.Text == palavra)
				{
					panel1.Enabled = false;
					pictureBox2.Visible = true;
					
					MessageBox.Show ("Parabuenas MUCHACHO, you win!!");
						
					button25.Visible = true;
					pictureBox2.Visible = false;
			}
			}
		}
		void Button21Click(object sender, EventArgs e)
		{
			char letra = 'T'; 
			int cont = 0; 
			string aux = ""; 
			for (int pos = 0; pos < palavra.Length; pos++)
			{
				if (letra == palavra[pos])
				{	
					cont++;
					aux += letra;
				}
				else	
				{
					aux += label2.Text[pos];
				}
			}
			
			label2.Text = aux; 
			if (cont == 0) 
			{
				contErros++;
				button21.BackColor = Color.Red;
				pictureBox1.Load("forca" + contErros +".png");
				if (contErros == 7)
				{
					panel1.Enabled = false;
					MessageBox.Show("Perdeu, Pureibói");
					button25.Visible = true;
				}
			}
			else
			{
				//button29.BackColor = Color.LightGreen;
				button21.BackColor = Color.LightGreen;
				if (label2.Text == palavra)
				{
					panel1.Enabled = false;
					pictureBox2.Visible = true;
					
					MessageBox.Show ("Parabuenas MUCHACHO, you win!!");
						
					button25.Visible = true;
					pictureBox2.Visible = false;
			}
			}
		}
		void Button24Click(object sender, EventArgs e)
		{
			char letra = 'U'; 
			int cont = 0; 
			string aux = ""; 
			for (int pos = 0; pos < palavra.Length; pos++)
			{
				if (letra == palavra[pos])
				{	
					cont++;
					aux += letra;
				}
				else	
				{
					aux += label2.Text[pos];
				}
			}
			
			label2.Text = aux; 
			if (cont == 0) 
			{
				contErros++;
				button24.BackColor = Color.Red;
				pictureBox1.Load("forca" + contErros +".png");
				if (contErros == 7)
				{
					panel1.Enabled = false;
					MessageBox.Show("Perdeu, Pureibói");
					button25.Visible = true;
				}
			}
			else
			{
				//button29.BackColor = Color.LightGreen;
				button24.BackColor = Color.LightGreen;
				if (label2.Text == palavra)
				{
					panel1.Enabled = false;
					pictureBox2.Visible = true;
					
					MessageBox.Show ("Parabuenas MUCHACHO, you win!!");
						
					button25.Visible = true;
					pictureBox2.Visible = false;
			}
			}
		}
		void Button26Click(object sender, EventArgs e)
		{
			char letra = 'V'; 
			int cont = 0; 
			string aux = ""; 
			for (int pos = 0; pos < palavra.Length; pos++)
			{
				if (letra == palavra[pos])
				{	
					cont++;
					aux += letra;
				}
				else	
				{
					aux += label2.Text[pos];
				}
			}
			
			label2.Text = aux; 
			if (cont == 0) 
			{
				contErros++;
				button26.BackColor = Color.Red;
				pictureBox1.Load("forca" + contErros +".png");
				if (contErros == 7)
				{
					panel1.Enabled = false;
					MessageBox.Show("Perdeu, Pureibói");
					button25.Visible = true;
				}
			}
			else
			{
				//button29.BackColor = Color.LightGreen;
				button26.BackColor = Color.LightGreen;
				if (label2.Text == palavra)
				{
					panel1.Enabled = false;
					pictureBox2.Visible = true;
					
					MessageBox.Show ("Parabuenas MUCHACHO, you win!!");
						
					button25.Visible = true;
					pictureBox2.Visible = false;
			}
			}
		}
		void Button28Click(object sender, EventArgs e)
		{
			char letra = 'W'; 
			int cont = 0; 
			string aux = ""; 
			for (int pos = 0; pos < palavra.Length; pos++)
			{
				if (letra == palavra[pos])
				{	
					cont++;
					aux += letra;
				}
				else	
				{
					aux += label2.Text[pos];
				}
			}
			
			label2.Text = aux; 
			if (cont == 0) 
			{
				contErros++;
				button28.BackColor = Color.Red;
				pictureBox1.Load("forca" + contErros +".png");
				if (contErros == 7)
				{
					panel1.Enabled = false;
					MessageBox.Show("Perdeu, Pureibói");
					button25.Visible = true;
				}
			}
			else
			{
				//button29.BackColor = Color.LightGreen;
				button28.BackColor = Color.LightGreen;
				if (label2.Text == palavra)
				{
					panel1.Enabled = false;
					pictureBox2.Visible = true;
					
					MessageBox.Show ("Parabuenas MUCHACHO, you win!!");
						
					button25.Visible = true;
					pictureBox2.Visible = false;
			}
			}}
		void Button27Click(object sender, EventArgs e)
		{
			char letra = 'X'; 
			int cont = 0; 
			string aux = ""; 
			for (int pos = 0; pos < palavra.Length; pos++)
			{
				if (letra == palavra[pos])
				{	
					cont++;
					aux += letra;
				}
				else	
				{
					aux += label2.Text[pos];
				}
			}
			
			label2.Text = aux; 
			if (cont == 0) 
			{
				contErros++;
				button27.BackColor = Color.Red;
				pictureBox1.Load("forca" + contErros +".png");
				if (contErros == 7)
				{
					panel1.Enabled = false;
					MessageBox.Show("Perdeu, Pureibói");
					button25.Visible = true;
				}
			}
			else
			{
				//button29.BackColor = Color.LightGreen;
				button27.BackColor = Color.LightGreen;
				if (label2.Text == palavra)
				{
					panel1.Enabled = false;
					pictureBox2.Visible = true;
					
					MessageBox.Show ("Parabuenas MUCHACHO, you win!!");
						
					button25.Visible = true;
					pictureBox2.Visible = false;
			}
			}}
		void Button30Click(object sender, EventArgs e)
		{
			char letra = 'Y'; 
			int cont = 0; 
			string aux = ""; 
			for (int pos = 0; pos < palavra.Length; pos++)
			{
				if (letra == palavra[pos])
				{	
					cont++;
					aux += letra;
				}
				else	
				{
					aux += label2.Text[pos];
				}
			}
			
			label2.Text = aux; 
			if (cont == 0) 
			{
				contErros++;
				button30.BackColor = Color.Red;
				pictureBox1.Load("forca" + contErros +".png");
				if (contErros == 7)
				{
					panel1.Enabled = false;
					MessageBox.Show("Perdeu, Pureibói");
					button25.Visible = true;
				}
			}
			else
			{
				//button29.BackColor = Color.LightGreen;
				button30.BackColor = Color.LightGreen;
				if (label2.Text == palavra)
				{
					panel1.Enabled = false;
					pictureBox2.Visible = true;
					
					MessageBox.Show ("Parabuenas MUCHACHO, you win!!");
						
					button25.Visible = true;
					pictureBox2.Visible = false;
			}
			}}
		void Button29Click(object sender, EventArgs e)
		{
			char letra = 'Z'; 
			int cont = 0; 
			string aux = ""; 
			for (int pos = 0; pos < palavra.Length; pos++)
			{
				if (letra == palavra[pos])
				{	
					cont++;
					aux += letra;
				}
				else	
				{
					aux += label2.Text[pos];
				}
			}
			
			label2.Text = aux; 
			if (cont == 0) 
			{
				contErros++;
				button29.BackColor = Color.Red; 
				pictureBox1.Load("forca" + contErros +".png");
				if (contErros == 7)
				{
					panel1.Enabled = false;
					MessageBox.Show("Perdeu, Pureibói");
					button25.Visible = true;
				}
			}
			else
			{
				//button29.BackColor = Color.LightGreen;
				button29.BackColor = Color.LightGreen;
				if (label2.Text == palavra)
				{
					panel1.Enabled = false;
					pictureBox2.Visible = true;
					
					MessageBox.Show ("Parabuenas MUCHACHO, you win!!");
						
					button25.Visible = true;
					pictureBox2.Visible = false;
					
				}
			}
		}*/
		void MainFormLoad(object sender, EventArgs e)
		{
	
		}
		void Panel1Paint(object sender, PaintEventArgs e)
		{
			
			
		}
		void Label1Click(object sender, EventArgs e)
		{
	
		}
		void PictureBox2Click(object sender, EventArgs e)
		{
	
		}
//		VERSÃO RESUMIDA DO CÓDIGO, PRATICAMENTE COM A MESMA FUNÇÃO
		
		void Button25Click(object sender, EventArgs e)
		{
			pictureBox1.Load ("forca0.png");
			panel1. Visible = true;
			panel1.Enabled = true;
			label2.Text ="";
			textBox1.Clear();
			contErros = 0;
			button3.Enabled = true;
			button3.Visible = true;
			Button[] bt = { button3, button4, button5, button7, button8, button9, button10, button22, button11, button12, button13,button14, button15, button16, button23, button17, button19, button18, button20, button21, button24, button26, button28, button27, button30, button29};
			for (int i = 0; i < 26; i++)
			{
				bt[i]. BackColor = Color. LightGray; 
				bt[i]. Enabled = true;
				bt [i]. Visible = true;
			}
			
			textBox1.Visible = true;
			textBox1.Enabled = true;
		}
		void TextBox1TextChanged(object sender, EventArgs e)
		{
	
		}
	}
}
