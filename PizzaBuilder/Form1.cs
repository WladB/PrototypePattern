using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaBuilder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Graphics g;
        Director director = new Director();
        BuilderHerbsPizza builder3 = new BuilderHerbsPizza();
        BuilderHuntingPizza builder1 = new BuilderHuntingPizza();
        BuilderMushroomsPizza builder2 = new BuilderMushroomsPizza();
        BuilderPizza builder4 = new BuilderPizza();
        int leftLocation=-170;
        PictureBox picture;
        byte count = 0;
       
        private void PBoxCreate()
        {
            
            picture = new PictureBox();
          
            leftLocation += 195;
            picture.Size = new Size(190, 190);
            picture.Left = leftLocation;
            picture.Top = 5;
            picture.Visible = true;
            picture.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(picture);
            picture.MouseClick += Form1_MouseClick;
            g = picture.CreateGraphics();
        }

            private void Drawing(List<Image> list){


            if (g != null) 
            {
               
                foreach (Image pizzaElement in list)
                {

                    if (pizzaElement.Tag.ToString() == "170")
                    {
                        MessageBox.Show("Готуємо основу");
                        g.DrawImage(pizzaElement, 6, 5, Convert.ToInt32(pizzaElement.Tag), Convert.ToInt32(pizzaElement.Tag));
                        
                    }
                    else
                    {
                        MessageBox.Show("Додамо ще трохи начинки");
                        g.DrawImage(pizzaElement, 25, 25, Convert.ToInt32(pizzaElement.Tag), Convert.ToInt32(pizzaElement.Tag));
                    }

                }
            }
            else {
                MessageBox.Show("Тарілку, куди викласти піцу, не обрано. Оберіть тарілку будь ласка");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (picture != null) {
                picture.Tag = "2";
            }
            builder3.Reset();
            director.Builder = builder3;
            director.Herbs_pizza();
           // builder4.SetProduct(builder3.GetProduct());
            Drawing(builder3.GetProduct().ListParts());
       
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            picture = sender as PictureBox;

            if (picture != null)
            {
                g = picture.CreateGraphics();
             
                
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (picture != null)
            {
                picture.Tag = "1";
            }
            builder2.Reset();
            director.Builder = builder2;
            director.Mushroom_pizza();
           // builder4.SetProduct(builder2.GetProduct());
            Drawing(builder2.GetProduct().ListParts());
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (picture != null)
            {
                picture.Tag = "0";
            }
            builder1.Reset();
            director.Builder = builder1;
            director.Hunting_pizza();
            //builder4.SetProduct(builder1.GetProduct());
            Drawing(builder1.GetProduct().ListParts());
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (count < 5)
            {
                PBoxCreate();
                count++;
            }
            else {
                MessageBox.Show("Ваш стіл вже й так заповнено, у вас не вистачить грошей, щоб розрахуватись за наступні страви");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (picture != null && picture.Tag!=null)
            {
                director.Builder = builder4;
                g = pictureBox2.CreateGraphics();
                switch (picture.Tag.ToString())
                {
                    case "0": builder4.SetProduct(builder1.GetProduct()); break;
                    case "1": builder4.SetProduct(builder2.GetProduct()); break;
                    case "2": builder4.SetProduct(builder3.GetProduct()); break;
                }
                Drawing(builder4.GetProduct().ListParts());
                g = picture.CreateGraphics();
            }
            else {
                MessageBox.Show("Оберіть піцу для клонування");
            }
            
        }
      }
    }

