using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tao.OpenGl;
using Tao.FreeGlut;

namespace TrabalhoFinal
{
    class Program
    {
        static float tx = 0.0f;
        static float ty = 0.0f;
        const float PI = 3.14f;
        static float rot = 0.0f;
        static bool auxTimer = false, auxPartida = true, auxChute=false;
        static Random auxRadom = new Random();
        static float auxGuardaRandom = 0.0f;
        static void inicializa()
        {
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glLoadIdentity();
            Glu.gluOrtho2D(0.0f, 1.0f, 0.0f, 1.0f);
            Gl.glClearColor(1.0f, 1.0f, 1.0f, 0.0f);
        }
        static void Timer(int value)
        {
            if (auxTimer)
            {
                if (tx < 0.75)
                {
                    tx += 0.1f;

                    //RELAÇÃO ALTURA
                    
                    ty += auxGuardaRandom * 0.014f;
                    
                    Glut.glutPostRedisplay();
                    Glut.glutTimerFunc(100, Timer, 1);
                }
                else
                {
                    auxTimer = false;
                }
            }
        }
        static void Ceu()
        {
            Gl.glBegin(Gl.GL_QUADS);
            Gl.glColor3f(0.47f, 0.47f, 1.0f);
                Gl.glVertex2f(0.0f, 0.4f);
                Gl.glVertex2f(1.0f, 0.4f);
                Gl.glVertex2f(1.0f, 1.0f);
                Gl.glVertex2f(0.0f, 1.0f);
            Gl.glEnd();
        }
        static void Grama()
        {
            Gl.glBegin(Gl.GL_QUADS);
            Gl.glColor3f(0.65f, 0.86f, 0.0f);
                Gl.glVertex2f(0.0f, 0.0f);
                Gl.glVertex2f(1.0f, 0.0f);
                Gl.glVertex2f(1.0f, 0.4f);
                Gl.glVertex2f(0.0f, 0.4f);
            Gl.glEnd();
        }
        static void Terra()
        {
            Gl.glBegin(Gl.GL_QUADS);
            Gl.glColor3f(0.58f, 0.29f, 0.0f);
                Gl.glVertex2f(0.0f, 0.0f);
                Gl.glVertex2f(1.0f, 0.0f);
                Gl.glVertex2f(1.0f, 0.08f);
                Gl.glVertex2f(0.0f, 0.08f);
            Gl.glEnd();
        }
        static void Nuvem()
        {
            float raio, x, y, pontos;
            raio = 0.05f;
            pontos = (2 * PI) / 52;
            Gl.glColor3f(1.0f, 1.0f, 1.0f);
            Gl.glLineWidth(15);
            Gl.glBegin(Gl.GL_TRIANGLE_FAN);
            for (float angulo = 0.0f; angulo <= 2 * PI; angulo += pontos)

            {
                x = (float)(raio * Math.Cos(angulo) + 0.1);
                y = (float)(raio * Math.Sin(angulo) + 0.9);
                Gl.glVertex2f(x, y);
            }
            Gl.glEnd();
            Glut.glutSwapBuffers();

            pontos = (2 * PI) / 52;
            Gl.glLineWidth(15);
            Gl.glBegin(Gl.GL_TRIANGLE_FAN);
            for (float angulo = 0.0f; angulo <= 2 * PI; angulo += pontos)

            {
                x = (float)(raio * Math.Cos(angulo) + 0.15);
                y = (float)(raio * Math.Sin(angulo) + 0.9);
                Gl.glVertex2f(x, y);
            }
            Gl.glEnd();
            Glut.glutSwapBuffers();

            pontos = (2 * PI) / 52;
            Gl.glLineWidth(15);
            Gl.glBegin(Gl.GL_TRIANGLE_FAN);
            for (float angulo = 0.0f; angulo <= 2 * PI; angulo += pontos)

            {
                x = (float)(raio * Math.Cos(angulo) + 0.2);
                y = (float)(raio * Math.Sin(angulo) + 0.9);
                Gl.glVertex2f(x, y);
            }
            Gl.glEnd();
            Glut.glutSwapBuffers();

            pontos = (2 * PI) / 52;
            Gl.glLineWidth(15);
            Gl.glBegin(Gl.GL_TRIANGLE_FAN);
            for (float angulo = 0.0f; angulo <= 2 * PI; angulo += pontos)

            {
                x = (float)(raio * Math.Cos(angulo) + 0.25);
                y = (float)(raio * Math.Sin(angulo) + 0.9);
                Gl.glVertex2f(x, y);
            }
            Gl.glEnd();
            Glut.glutSwapBuffers();

            /////////////////////////////////////////////

            pontos = (2 * PI) / 52;
            Gl.glLineWidth(15);
            Gl.glBegin(Gl.GL_TRIANGLE_FAN);
            for (float angulo = 0.0f; angulo <= 2 * PI; angulo += pontos)

            {
                x = (float)(raio * Math.Cos(angulo) + 0.01);
                y = (float)(raio * Math.Sin(angulo) + 0.7);
                Gl.glVertex2f(x, y);
            }
            Gl.glEnd();
            Glut.glutSwapBuffers();

            pontos = (2 * PI) / 52;
            Gl.glLineWidth(15);
            Gl.glBegin(Gl.GL_TRIANGLE_FAN);
            for (float angulo = 0.0f; angulo <= 2 * PI; angulo += pontos)

            {
                x = (float)(raio * Math.Cos(angulo) + 0.05);
                y = (float)(raio * Math.Sin(angulo) + 0.7);
                Gl.glVertex2f(x, y);
            }
            Gl.glEnd();
            Glut.glutSwapBuffers();

            pontos = (2 * PI) / 52;
            Gl.glLineWidth(15);
            Gl.glBegin(Gl.GL_TRIANGLE_FAN);
            for (float angulo = 0.0f; angulo <= 2 * PI; angulo += pontos)

            {
                x = (float)(raio * Math.Cos(angulo) + 0.1);
                y = (float)(raio * Math.Sin(angulo) + 0.7);
                Gl.glVertex2f(x, y);
            }
            Gl.glEnd();
            Glut.glutSwapBuffers();
        }
        static void Sol()
        {
            float raio, x, y, pontos;
            raio = 0.1f;
            pontos = (2 * PI) / 52;
            Gl.glColor3f(1.0f, 1.0f, 0.0f);
            Gl.glLineWidth(15);
            Gl.glBegin(Gl.GL_TRIANGLE_FAN);
            for (float angulo = 0.0f; angulo <= 2 * PI; angulo += pontos)

            {
                x = (float)(raio * Math.Cos(angulo) + 0.9);
                y = (float)(raio * Math.Sin(angulo) + 0.9);
                Gl.glVertex2f(x, y);
            }
            Gl.glEnd();
            Glut.glutSwapBuffers();
        }
        static void Trave()
        {
            Gl.glColor3f(1.0f, 1.0f, 1.0f);
            Gl.glLineWidth(12);

            Gl.glBegin(Gl.GL_LINE_STRIP); 
                Gl.glVertex2f(0.9f, 0.3f);
                Gl.glVertex2f(0.9f, 0.6f);
                Gl.glVertex2f(0.7f, 0.6f);
                Gl.glVertex2f(0.7f, 0.3f);
            Gl.glEnd();

            Gl.glColor3f(1.0f, 1.0f, 1.0f);
            Gl.glBegin(Gl.GL_LINES);
                Gl.glVertex2f(0.9f, 0.6f);
                Gl.glVertex2f(0.99f, 0.5f);
            Gl.glEnd();

            Gl.glColor3f(1.0f, 1.0f, 1.0f);
                Gl.glBegin(Gl.GL_LINES);
                Gl.glVertex2f(0.99f, 0.5f);
                Gl.glVertex2f(0.99f, 0.3f);
            Gl.glEnd();

            //LINHAS GOL
            Gl.glColor3f(1.0f, 1.0f, 1.0f);
            Gl.glLineWidth(5);
            Gl.glBegin(Gl.GL_LINES);
                Gl.glVertex2f(0.92f, 0.58f);
                Gl.glVertex2f(0.92f, 0.3f);

                Gl.glVertex2f(0.94f, 0.56f);
                Gl.glVertex2f(0.94f, 0.3f);

                Gl.glVertex2f(0.96f, 0.54f);
                Gl.glVertex2f(0.96f, 0.3f);

                Gl.glVertex2f(0.975f, 0.51f);
                Gl.glVertex2f(0.975f, 0.3f);
                
            ///////
                Gl.glVertex2f(0.9f, 0.55f);
                Gl.glVertex2f(0.95f, 0.55f);

                Gl.glVertex2f(0.9f, 0.50f);
                Gl.glVertex2f(0.99f, 0.50f);

                Gl.glVertex2f(0.9f, 0.45f);
                Gl.glVertex2f(0.99f, 0.45f);

                Gl.glVertex2f(0.9f, 0.40f);
                Gl.glVertex2f(0.99f, 0.40f);

                Gl.glVertex2f(0.9f, 0.35f);
                Gl.glVertex2f(0.99f, 0.35f);

                Gl.glVertex2f(0.9f, 0.31f);
                Gl.glVertex2f(0.99f, 0.31f);
            Gl.glEnd();

            /////////////////////////
            Gl.glColor3f(0.0f, 0.49f, 0.0f);
            Gl.glLineWidth(12);
            Gl.glBegin(Gl.GL_LINES);
                Gl.glVertex2f(0.5f, 0.29f);
                Gl.glVertex2f(0.999f, 0.29f);
            Gl.glEnd();
        }
        static void Bola()
        {
            float raio, x, y, pontos;
            raio = 0.03f;
            pontos = (2 * PI) / 52;
            Gl.glColor3f(1.0f, 0.64f, 0.0f);
            Gl.glLineWidth(15);
            Gl.glBegin(Gl.GL_TRIANGLE_FAN);
            for (float angulo = 0.0f; angulo <= 2 * PI; angulo += pontos)

            {
                x = (float)(raio * Math.Cos(angulo) + 0.18);
                y = (float)(raio * Math.Sin(angulo) + 0.15);
                Gl.glVertex2f(x, y);
            }
            Gl.glEnd();
            Glut.glutSwapBuffers();
        }
        static void Boneco()
        {
            //CABEÇA
            float raio, x, y, pontos;
            raio = 0.05f;
            pontos = (2 * PI) / 52;
            Gl.glColor3f(0.0f, 0.0f, 0.0f);
            Gl.glLineWidth(15);
            Gl.glBegin(Gl.GL_TRIANGLE_FAN);
            for (float angulo = 0.0f; angulo <= 2 * PI; angulo += pontos)

            {
                x = (float)(raio * Math.Cos(angulo) + 0.1);
                y = (float)(raio * Math.Sin(angulo) + 0.5);
                Gl.glVertex2f(x, y);
            }
            Gl.glEnd();

            //CORPO
            Gl.glColor3f(0.0f, 0.0f, 0.0f);
            Gl.glLineWidth(12);
            Gl.glBegin(Gl.GL_LINES);
                Gl.glVertex2f(0.1f, 0.45f);
                Gl.glVertex2f(0.1f, 0.26f);
            Gl.glEnd();

            //PERNA ESQUERDA
            Gl.glColor3f(0.0f, 0.0f, 0.0f);
            Gl.glLineWidth(10);
            Gl.glBegin(Gl.GL_LINES);
                Gl.glVertex2f(0.1f, 0.27f);
                Gl.glVertex2f(0.08f, 0.14f);
            Gl.glEnd();

            //BRAÇO CIMA
            Gl.glColor3f(0.0f, 0.0f, 0.0f);
            Gl.glLineWidth(10);
            Gl.glBegin(Gl.GL_LINES);
                Gl.glVertex2f(0.1f, 0.38f);
                Gl.glVertex2f(0.17f, 0.45f);
            Gl.glEnd();

            //BRAÇO BAIXO
            Gl.glColor3f(0.0f, 0.0f, 0.0f);
            Gl.glLineWidth(10);
            Gl.glBegin(Gl.GL_LINES);
                Gl.glVertex2f(0.1f, 0.35f);
                Gl.glVertex2f(0.17f, 0.35f);
            Gl.glEnd();
        }

        static void CompletaPerna()
        {
            Gl.glColor3f(0.0f, 0.0f, 0.0f);
            Gl.glLineWidth(10);
            Gl.glBegin(Gl.GL_LINES);
            Gl.glVertex2f(0.1f, 0.263f);
            Gl.glVertex2f(0.14f, 0.263f);
            Gl.glEnd();
        }
        static void PernaDireita()
        {
            Gl.glColor3f(0.0f, 0.0f, 0.0f);
            Gl.glLineWidth(10);

            Gl.glPushMatrix();

            Gl.glTranslatef(0.19f, 0.4f, 0.0f); //Translação
            Gl.glRotatef(rot, 1.0f, 0.0f, 1.0f);// Rotação


            Gl.glBegin(Gl.GL_LINES);
            Gl.glVertex2f(-0.04f, -0.27f);
            Gl.glVertex2f(-0.09f, -0.12f);
            Gl.glEnd();

            Gl.glPopMatrix();
            Glut.glutSwapBuffers();
        }

        static void VerificaGol()
        {
            if((auxGuardaRandom > 1) && (auxGuardaRandom < 5))
            {
                Gl.glBegin(Gl.GL_QUADS);
                Gl.glColor3f(1.0f, 1.0f, 1.0f);
                    Gl.glVertex2f(0.3f, 0.7f);
                    Gl.glVertex2f(0.7f, 0.7f);
                    Gl.glVertex2f(0.7f, 0.9f);
                    Gl.glVertex2f(0.4f, 0.9f);
                Gl.glEnd();

                //G
                Gl.glColor3f(0.0f, 0.0f, 0.0f);
                Gl.glLineWidth(5);

                Gl.glBegin(Gl.GL_LINES);
                    Gl.glVertex2f(0.50f, 0.85f);
                    Gl.glVertex2f(0.45f, 0.85f);

                    Gl.glVertex2f(0.45f, 0.85f);
                    Gl.glVertex2f(0.45f, 0.75f);

                    Gl.glVertex2f(0.45f, 0.75f);
                    Gl.glVertex2f(0.50f, 0.75f);

                    Gl.glVertex2f(0.50f, 0.75f);
                    Gl.glVertex2f(0.50f, 0.80f);

                    Gl.glVertex2f(0.50f, 0.80f);
                    Gl.glVertex2f(0.48f, 0.80f);
                Gl.glEnd();

                //O
                Gl.glBegin(Gl.GL_LINE_LOOP); 
                    Gl.glVertex2f(0.52f, 0.85f);
                    Gl.glVertex2f(0.52f, 0.75f); 
                    Gl.glVertex2f(0.57f, 0.75f); 
                    Gl.glVertex2f(0.57f, 0.85f); 
                Gl.glEnd();

                //L
                Gl.glBegin(Gl.GL_LINES);
                    Gl.glVertex2f(0.59f, 0.85f); 
                    Gl.glVertex2f(0.59f, 0.75f);
                    Gl.glVertex2f(0.59f, 0.75f);
                    Gl.glVertex2f(0.64f, 0.75f); 
                Gl.glEnd();

                Gl.glFlush();
            }
            else
            {
                Gl.glBegin(Gl.GL_QUADS);
                Gl.glColor3f(1.0f, 1.0f, 1.0f);
                    Gl.glVertex2f(0.3f, 0.7f);
                    Gl.glVertex2f(0.78f, 0.7f);
                    Gl.glVertex2f(0.78f, 0.9f);
                    Gl.glVertex2f(0.4f, 0.9f);
                Gl.glEnd();

                Gl.glColor3f(0.0f, 0.0f, 0.0f);
                Gl.glLineWidth(5);

                //E
                Gl.glBegin(Gl.GL_LINES);
                    Gl.glVertex2f(0.50f, 0.85f);
                    Gl.glVertex2f(0.45f, 0.85f);

                    Gl.glVertex2f(0.45f, 0.85f);
                    Gl.glVertex2f(0.45f, 0.80f);

                    Gl.glVertex2f(0.45f, 0.80f);
                    Gl.glVertex2f(0.50f, 0.80f);

                    Gl.glVertex2f(0.45f, 0.80f);
                    Gl.glVertex2f(0.45f, 0.75f);

                    Gl.glVertex2f(0.45f, 0.75f);
                    Gl.glVertex2f(0.50f, 0.75f);

                    Gl.glVertex2f(0.45f, 0.75f);
                    Gl.glVertex2f(0.50f, 0.75f);

                    //R
                    Gl.glVertex2f(0.57f, 0.85f);
                    Gl.glVertex2f(0.52f, 0.85f);

                    Gl.glVertex2f(0.52f, 0.85f);
                    Gl.glVertex2f(0.52f, 0.80f);

                    Gl.glVertex2f(0.52f, 0.80f);
                    Gl.glVertex2f(0.57f, 0.80f);

                    Gl.glVertex2f(0.57f, 0.80f);
                    Gl.glVertex2f(0.57f, 0.85f);

                    Gl.glVertex2f(0.52f, 0.80f);
                    Gl.glVertex2f(0.52f, 0.75f);

                    Gl.glVertex2f(0.52f, 0.80f);
                    Gl.glVertex2f(0.57f, 0.75f);

                    //R
                    Gl.glVertex2f(0.64f, 0.85f);
                    Gl.glVertex2f(0.59f, 0.85f);

                    Gl.glVertex2f(0.59f, 0.85f);
                    Gl.glVertex2f(0.59f, 0.80f);

                    Gl.glVertex2f(0.59f, 0.80f);
                    Gl.glVertex2f(0.64f, 0.80f);

                    Gl.glVertex2f(0.64f, 0.80f);
                    Gl.glVertex2f(0.64f, 0.85f);

                    Gl.glVertex2f(0.59f, 0.80f);
                    Gl.glVertex2f(0.59f, 0.75f);

                    Gl.glVertex2f(0.59f, 0.80f);
                    Gl.glVertex2f(0.64f, 0.75f);
                    
                    //U
                    Gl.glVertex2f(0.73f, 0.85f);
                    Gl.glVertex2f(0.73f, 0.75f);

                    Gl.glVertex2f(0.73f, 0.75f);
                    Gl.glVertex2f(0.77f, 0.75f);

                    Gl.glVertex2f(0.77f, 0.75f);
                    Gl.glVertex2f(0.77f, 0.85f);
                Gl.glEnd();

                //O
                Gl.glBegin(Gl.GL_LINE_LOOP);
                    Gl.glVertex2f(0.66f, 0.85f);
                    Gl.glVertex2f(0.66f, 0.75f);
                    Gl.glVertex2f(0.71f, 0.75f);
                    Gl.glVertex2f(0.71f, 0.85f);
                Gl.glEnd();
            }
        }
        static void desenha()
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
            Ceu();
            Grama();
            Trave();
            Terra();
            Sol();
            Nuvem();
            Boneco();
            PernaDireita();
            if (auxChute==true)
                CompletaPerna();
            if(auxPartida==false)
                VerificaGol();
            Gl.glPushMatrix();
            Gl.glTranslatef(tx, ty, 0.0f);
            Bola();
            Gl.glPopMatrix();

        }
        static void TeclasEspeciais(int key, int x, int y)
        {
            if (auxPartida == true)
            {
                switch (key)
                {
                    case Glut.GLUT_KEY_RIGHT:
                        auxGuardaRandom = auxRadom.Next(1, 10);
                        auxPartida = false;
                        auxTimer = true;
                        auxChute = true;
                        Glut.glutTimerFunc(100, Timer,1);
                        rot += 25;
                        break;
                }
                Glut.glutPostRedisplay();
            }
        }
        static void Main()
        {
            Glut.glutInit();
            Glut.glutInitDisplayMode(Glut.GLUT_SINGLE | Glut.GLUT_RGB);
            Glut.glutInitWindowSize(1024, 720);
            Glut.glutCreateWindow("Projeto");
            inicializa();
            Glut.glutDisplayFunc(desenha);
            Glut.glutSpecialFunc(TeclasEspeciais);
            Glut.glutMainLoop();
        }
    }
}
