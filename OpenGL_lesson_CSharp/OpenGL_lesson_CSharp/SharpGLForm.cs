using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SharpGL;

namespace OpenGL_lesson_CSharp
{
    public partial class SharpGLForm : Form
    {
        float rotation = 0.0f;
        public SharpGLForm()
        {
            InitializeComponent();
        }

        private void openGLControl_OpenGLDraw(object sender, RenderEventArgs e)
        {
            //  Возьмём OpenGL объект
            OpenGL gl = openGLControl.OpenGL;

            //  Очищаем буфер цвета и глубины
            gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);

            //  Загружаем единичную матрицу
            gl.LoadIdentity();

            //  Указываем оси вращения (x, y, z)
            gl.Rotate(rotation, 0.0f, 1.0f, 0.0f);

            // Гусеницы, 5 плоскостей
            float x = 0.0f, y = 0.0f, z = 0.0f;
            float xx = 1.0f, yy = 0.3f, zz = 2.0f;

            gl.Begin(OpenGL.GL_POLYGON);
            gl.Color(0.3f, 0.3f, 0.3f);
            gl.Vertex(x - (1.0f * xx), y - (1.0f * yy), z - (1.0f * zz));
            gl.Vertex(x - (1.0f * xx), y - (1.0f * yy), z + (1.0f * zz));
            gl.Vertex(x + (1.0f * xx), y - (1.0f * yy), z + (1.0f * zz));
            gl.Vertex(x + (1.0f * xx), y - (1.0f * yy), z - (1.0f * zz));
            gl.End();

            gl.Begin(OpenGL.GL_POLYGON);
            gl.Color(0.3f, 0.3f, 0.3f);
            gl.Vertex(x + (1.0f * xx), y - (1.0f * yy), z - (1.0f * zz));
            gl.Vertex(x + (1.0f * xx), y + (1.0f * yy), z - (1.0f * zz));
            gl.Vertex(x + (1.0f * xx), y + (1.0f * yy), z + (1.0f * zz));
            gl.Vertex(x + (1.0f * xx), y - (1.0f * yy), z + (1.0f * zz));
            gl.End();

            gl.Begin(OpenGL.GL_POLYGON);
            gl.Color(0.3f, 0.3f, 0.3f);
            gl.Vertex(x - (1.0f * xx), y - (1.0f * yy), z - (1.0f * zz));
            gl.Vertex(x - (1.0f * xx), y + (1.0f * yy), z - (1.0f * zz));
            gl.Vertex(x - (1.0f * xx), y + (1.0f * yy), z + (1.0f * zz));
            gl.Vertex(x - (1.0f * xx), y - (1.0f * yy), z + (1.0f * zz));
            gl.End();

            gl.Begin(OpenGL.GL_POLYGON);
            gl.Color(0.3f, 0.3f, 0.3f);
            gl.Vertex(x - (1.0f * xx), y - (1.0f * yy), z - (1.0f * zz));
            gl.Vertex(x - (1.0f * xx), y + (1.0f * yy), z - (1.0f * zz));
            gl.Vertex(x + (1.0f * xx), y + (1.0f * yy), z - (1.0f * zz));
            gl.Vertex(x + (1.0f * xx), y - (1.0f * yy), z - (1.0f * zz));
            gl.End();

            gl.Begin(OpenGL.GL_POLYGON);
            gl.Color(0.3f, 0.3f, 0.3f);
            gl.Vertex(x - (1.0f * xx), y - (1.0f * yy), z + (1.0f * zz));
            gl.Vertex(x - (1.0f * xx), y + (1.0f * yy), z + (1.0f * zz));
            gl.Vertex(x + (1.0f * xx), y + (1.0f * yy), z + (1.0f * zz));
            gl.Vertex(x + (1.0f * xx), y - (1.0f * yy), z + (1.0f * zz));
            gl.End();

            // Корпус, 5 плоскостей
            x = 0.0f; y = 0.8f; z = 0.0f;
            xx = 1.0f; yy = 0.5f; zz = 2.0f; 

            gl.Begin(OpenGL.GL_POLYGON);
            gl.Color(0.0f, 0.45f, 0.0f);
            gl.Vertex(x - (1.0f * xx), y + (1.0f * yy), z - (1.0f * zz));
            gl.Vertex(x - (1.0f * xx), y + (1.0f * yy), z + (1.0f * zz));
            gl.Vertex(x + (1.0f * xx), y + (1.0f * yy), z + (1.0f * zz));
            gl.Vertex(x + (1.0f * xx), y + (1.0f * yy), z - (1.0f * zz));
            gl.End();

            gl.Begin(OpenGL.GL_POLYGON);
            gl.Color(0.0f, 0.4f, 0.0f);
            gl.Vertex(x - (1.0f * xx), y - (1.0f * yy), z - (1.0f * zz));
            gl.Vertex(x - (1.0f * xx), y - (1.0f * yy), z + (1.0f * zz));
            gl.Vertex(x - (1.0f * xx), y + (1.0f * yy), z + (1.0f * zz));
            gl.Vertex(x - (1.0f * xx), y + (1.0f * yy), z - (1.0f * zz));
            gl.End();

            gl.Begin(OpenGL.GL_POLYGON);
            gl.Color(0.0f, 0.4f, 0.0f);
            gl.Vertex(x - (1.0f * xx), y - (1.0f * yy), z + (1.0f * zz));
            gl.Vertex(x + (1.0f * xx), y - (1.0f * yy), z + (1.0f * zz));
            gl.Vertex(x + (1.0f * xx), y + (1.0f * yy), z + (1.0f * zz));
            gl.Vertex(x - (1.0f * xx), y + (1.0f * yy), z + (1.0f * zz));
            gl.End();

            gl.Begin(OpenGL.GL_POLYGON);
            gl.Color(0.0f, 0.4f, 0.0f);
            gl.Vertex(x + (1.0f * xx), y - (1.0f * yy), z - (1.0f * zz));
            gl.Vertex(x + (1.0f * xx), y - (1.0f * yy), z + (1.0f * zz));
            gl.Vertex(x + (1.0f * xx), y + (1.0f * yy), z + (1.0f * zz));
            gl.Vertex(x + (1.0f * xx), y + (1.0f * yy), z - (1.0f * zz));
            gl.End();

            gl.Begin(OpenGL.GL_POLYGON);
            gl.Color(0.0f, 0.4f, 0.0f);
            gl.Vertex(x - (1.0f * xx), y - (1.0f * yy), z - (1.0f * zz));
            gl.Vertex(x + (1.0f * xx), y - (1.0f * yy), z - (1.0f * zz));
            gl.Vertex(x + (1.0f * xx), y + (1.0f * yy), z - (1.0f * zz));
            gl.Vertex(x - (1.0f * xx), y + (1.0f * yy), z - (1.0f * zz));
            gl.End();

            // Башня, 5 плоскостей
            x = 0.0f; y = 1.7f; z = 0.7f;
            xx = 1.0f; yy = 0.7f; zz = 1.0f;

            gl.Begin(OpenGL.GL_POLYGON);
            gl.Color(0.0f, 0.3f, 0.0f);
            gl.Vertex(x - (0.505f * xx), y - (0.556f * yy), z - (0.530f * zz));
            gl.Vertex(x - (0.505f * xx), y - (0.556f * yy), z + (0.530f * zz));
            gl.Vertex(x - (0.505f * xx), y + (0.556f * yy), z + (0.530f * zz));
            gl.Vertex(x - (0.505f * xx), y + (0.556f * yy), z - (0.530f * zz));
            gl.End();

            gl.Begin(OpenGL.GL_POLYGON);
            gl.Color(0.0f, 0.3f, 0.0f);
            gl.Vertex(x - (0.505f * xx), y - (0.556f * yy), z + (0.530f * zz));
            gl.Vertex(x + (0.505f * xx), y - (0.556f * yy), z + (0.530f * zz));
            gl.Vertex(x + (0.505f * xx), y + (0.556f * yy), z + (0.530f * zz));
            gl.Vertex(x - (0.505f * xx), y + (0.556f * yy), z + (0.530f * zz));
            gl.End();

            gl.Begin(OpenGL.GL_POLYGON);
            gl.Color(0.0f, 0.3f, 0.0f);
            gl.Vertex(x - (0.505f * xx), y - (0.556f * yy), z - (0.530f * zz));
            gl.Vertex(x + (0.505f * xx), y - (0.556f * yy), z - (0.530f * zz));
            gl.Vertex(x + (0.505f * xx), y + (0.556f * yy), z - (0.530f * zz));
            gl.Vertex(x - (0.505f * xx), y + (0.556f * yy), z - (0.530f * zz));
            gl.End();

            gl.Begin(OpenGL.GL_POLYGON);
            gl.Color(0.0f, 0.3f, 0.0f);
            gl.Vertex(x + (0.505f * xx), y - (0.556f * yy), z - (0.530f * zz));
            gl.Vertex(x + (0.505f * xx), y - (0.556f * yy), z + (0.530f * zz));
            gl.Vertex(x + (0.505f * xx), y + (0.556f * yy), z + (0.530f * zz));
            gl.Vertex(x + (0.505f * xx), y + (0.556f * yy), z - (0.530f * zz));
            gl.End();

            gl.Begin(OpenGL.GL_POLYGON);
            gl.Color(0.0f, 0.35f, 0.0f);
            gl.Vertex(x - (0.505f * xx), y + (0.556f * yy), z - (0.530f * zz));
            gl.Vertex(x - (0.505f * xx), y + (0.556f * yy), z + (0.530f * zz));
            gl.Vertex(x + (0.505f * xx), y + (0.556f * yy), z + (0.530f * zz));
            gl.Vertex(x + (0.505f * xx), y + (0.556f * yy), z - (0.530f * zz));
            gl.End();

            // Ствол, 5 плоскостей
            x = 0.0f; y = 1.725f; z = -0.843f;
            xx = 1.0f; yy = 1.0f; zz = 1.0f;

            gl.Begin(OpenGL.GL_POLYGON);
            gl.Color(0.0f, 0.37f, 0.0f);
            gl.Vertex(x - (0.129f * xx), y + (0.173f * yy), z - (1.014f * zz));
            gl.Vertex(x - (0.129f * xx), y + (0.173f * yy), z + (1.014f * zz));
            gl.Vertex(x + (0.129f * xx), y + (0.173f * yy), z + (1.014f * zz));
            gl.Vertex(x + (0.129f * xx), y + (0.173f * yy), z - (1.014f * zz));
            gl.End();

            gl.Begin(OpenGL.GL_POLYGON);
            gl.Color(0.0f, 0.37f, 0.0f);
            gl.Vertex(x - (0.129f * xx), y - (0.173f * yy), z - (1.014f * zz));
            gl.Vertex(x + (0.129f * xx), y - (0.173f * yy), z - (1.014f * zz));
            gl.Vertex(x + (0.129f * xx), y + (0.173f * yy), z - (1.014f * zz));
            gl.Vertex(x - (0.129f * xx), y + (0.173f * yy), z - (1.014f * zz));
            gl.End();

            gl.Begin(OpenGL.GL_POLYGON);
            gl.Color(0.0f, 0.37f, 0.0f);
            gl.Vertex(x - (0.129f * xx), y - (0.173f * yy), z - (1.014f * zz));
            gl.Vertex(x - (0.129f * xx), y - (0.173f * yy), z + (1.014f * zz));
            gl.Vertex(x + (0.129f * xx), y - (0.173f * yy), z + (1.014f * zz));
            gl.Vertex(x + (0.129f * xx), y - (0.173f * yy), z - (1.014f * zz));
            gl.End();

            gl.Begin(OpenGL.GL_POLYGON);
            gl.Color(0.0f, 0.37f, 0.0f);
            gl.Vertex(x - (0.129f * xx), y - (0.173f * yy), z - (1.014f * zz));
            gl.Vertex(x - (0.129f * xx), y - (0.173f * yy), z + (1.014f * zz));
            gl.Vertex(x - (0.129f * xx), y + (0.173f * yy), z + (1.014f * zz));
            gl.Vertex(x - (0.129f * xx), y + (0.173f * yy), z - (1.014f * zz));
            gl.End();

            gl.Begin(OpenGL.GL_POLYGON);
            gl.Color(0.0f, 0.37f, 0.0f);
            gl.Vertex(x + (0.129f * xx), y - (0.173f * yy), z - (1.014f * zz));
            gl.Vertex(x + (0.129f * xx), y - (0.173f * yy), z + (1.014f * zz));
            gl.Vertex(x + (0.129f * xx), y + (0.173f * yy), z + (1.014f * zz));
            gl.Vertex(x + (0.129f * xx), y + (0.173f * yy), z - (1.014f * zz));
            gl.End();


            rotation += 1.0f;
        }

        // Эту функцию используем для задания некоторых значений по умолчанию
        private void openGLControl_OpenGLInitialized(object sender, EventArgs e)
        {
            //  Возьмём OpenGL объект
            OpenGL gl = openGLControl.OpenGL;

            //  Фоновый цвет по умолчанию (в данном случае цвет голубой)
            gl.ClearColor(1.0f, 1.0f, 1.0f, 0);
        }

        // Данная функция используется для преобразования изображения 
        // в объёмный вид с перспективой
        private void openGLControl_Resized(object sender, EventArgs e)
        {
            //  Возьмём OpenGL объект
            OpenGL gl = openGLControl.OpenGL;

            //  Зададим матрицу проекции
            gl.MatrixMode(OpenGL.GL_PROJECTION);

            //  Единичная матрица для последующих преобразований
            gl.LoadIdentity();

            //  Преобразование
            gl.Perspective(60.0f, (double)Width / (double)Height, 0.01, 100.0);

            //  Данная функция позволяет установить камеру и её положение
            gl.LookAt(5, 6, -7,    // Позиция самой камеры
                       0, 1, 0,     // Направление, куда мы смотрим
                       0, 1, 0);    // Верх камеры

            //  Зададим модель отображения
            gl.MatrixMode(OpenGL.GL_MODELVIEW);
        }
    }
}