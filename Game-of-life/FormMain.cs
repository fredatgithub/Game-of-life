using System;
using System.Drawing;
using System.Windows.Forms;

namespace Game_of_life
{
  public partial class FormMain : Form
  {
    public FormMain()
    {
      InitializeComponent();
    }

    static Random GetRandom = new Random();
    static int res = 10;
    static int cols = 1860 / res;//460
    static int rows = 920 / res;//320
    static int off = 0;
    static int generation = 0;
    static int[] moreZero = { 0, 0, 1 };

    public static int[,] grid = Make2Darray(cols, rows);


    private void Form1_Load(object sender, EventArgs e)
    {
      timer1.Interval = 50;
      numericUpDown1.Value = timer1.Interval / 10;
      geneBox.Text = $"{generation}";

    }

    static int[,] Make2Darray(int cols, int rows)
    {
      int[,] array = new int[cols, rows];
      return array;
    }
    static void UpdateDraw(Control obj)
    {
      Graphics graphics = obj.CreateGraphics();
      SolidBrush bBlack = new SolidBrush(Color.Black),
                 bWhite = new SolidBrush(Color.White); ;
      for (int i = 0; i < cols; i++)
      {
        for (int j = 0; j < rows; j++)
        {
          int x = i * res;
          int y = j * res;

          if (grid[i, j] == 1)
            graphics.FillRectangle(bBlack, new Rectangle(x, y, res - off, res - off));
          else
            graphics.FillRectangle(bWhite, new Rectangle(x, y, res - off, res - off));
        }
      }

      graphics.Dispose();
      bBlack.Dispose();
      bWhite.Dispose();
    }

    static void BeginGrowth(Control obj)
    {
      Graphics graphics = obj.CreateGraphics();
      //Pen pBlack = new Pen(Color.Gray, 1);
      SolidBrush bBlack = new SolidBrush(Color.Black), bWhite = new SolidBrush(Color.White);
      for (int i = 0; i < cols; i++)
      {
        for (int j = 0; j < rows; j++)
        {
          int x = i * res;
          int y = j * res;

          if (grid[i, j] == 1)
            graphics.FillRectangle(bBlack, new Rectangle(x, y, res - off, res - off));
          else
            graphics.FillRectangle(bWhite, new Rectangle(x, y, res - off, res - off));
        }
      }

      var newGrid = Make2Darray(cols, rows);
      // Compute newGrid based on grid
      for (int i = 0; i < cols; i++)
      {
        for (int j = 0; j < rows; j++)
        {
          int state = grid[i, j];

          // Calculate neighbors
          var neighbors = CountNeighs(grid, i, j, cols, rows);
          if (state == 0 && neighbors == 3)
            newGrid[i, j] = 1;
          else if (state == 1 && (neighbors < 2 || neighbors > 3))
            newGrid[i, j] = 0;
          else
            newGrid[i, j] = state;

        }
      }

      grid = newGrid;

      bBlack.Dispose();
      bWhite.Dispose();
      graphics.Dispose();
    }

    static int[,] Populate(int[,] _2Darray)
    {

      for (int i = 0; i < cols; i++)
      {
        for (int j = 0; j < rows; j++)
        {
          grid[i, j] = moreZero[GetRandom.Next(moreZero.Length)];
        }
      }
      return _2Darray;
    }

    static int[,] ZeroFill(int[,] _2Darray)
    {
      for (int i = 0; i < cols; i++)
      {
        for (int j = 0; j < rows; j++)
        {
          grid[i, j] = 0;
        }
      }
      return _2Darray;
    }

    static int CountNeighs(int[,] grid, int x, int y, int cols, int rows)
    {
      int sum = 0;
      if (x == 0)
      {
        if (y == 0)
        {
          for (int i = 0; i < 2; i++)
          {
            for (int j = 0; j < 2; j++)
            {
              sum += grid[x + i, y + j];
            }
          }
        }
        else if (y == rows - 1)
        {
          for (int i = 0; i < 2; i++)
          {
            for (int j = -1; j < 1; j++)
            {
              sum += grid[x + i, y + j];
            }
          }
        }
        else
        {
          for (int i = 0; i < 2; i++)
          {
            for (int j = -1; j < 2; j++)
            {
              sum += grid[x + i, y + j];
            }
          }
        }
      }
      else if (x == cols - 1)
      {
        if (y == 0)
        {
          for (int i = -1; i < 1; i++)
          {
            for (int j = 0; j < 2; j++)
            {
              sum += grid[x + i, y + j];
            }
          }
        }
        else if (y == rows - 1)
        {
          for (int i = -1; i < 1; i++)
          {
            for (int j = -1; j < 1; j++)
            {
              sum += grid[x + i, y + j];
            }
          }
        }
        else
        {
          for (int i = -1; i < 1; i++)
          {
            for (int j = -1; j < 2; j++)
            {
              sum += grid[x + i, y + j];
            }
          }
        }
      }
      else if (y == 0)
      {
        for (int i = -1; i < 2; i++)
        {
          for (int j = 0; j < 2; j++)
          {
            sum += grid[x + i, y + j];
          }
        }
      }
      else if (y == rows - 1)
      {
        for (int i = -1; i < 2; i++)
        {
          for (int j = -1; j < 1; j++)
          {
            sum += grid[x + i, y + j];
          }
        }
      }
      else
      {
        for (int i = -1; i < 2; i++)
        {
          for (int j = -1; j < 2; j++)
          {
            sum += grid[x + i, y + j];
          }
        }
      }

      sum -= grid[x, y];
      return sum;
    }

    private void Timer1_Tick(object sender, EventArgs e)
    {
      geneBox.Text = $"{generation++}";
      BeginGrowth(mainPanel);
    }

    private void ButtonPopulate_Click(object sender, EventArgs e)
    {
      ZeroFill(grid);
      Populate(grid);
      UpdateDraw(mainPanel);
    }

    private void StartButton_Click(object sender, EventArgs e)
    {
      generation = 0;
      startButton.Enabled = false;
      buttonPopulate.Enabled = false;
      restartButton.Enabled = true;
      timer1.Enabled = true;
    }

    private void RestartButton_Click(object sender, EventArgs e)
    {
      if (timer1.Enabled)
      {
        generation = 0;
        ZeroFill(grid);
        timer1.Stop();
        timer1.Enabled = false;
        startButton.Enabled = true;
        buttonPopulate.Enabled = true;
        restartButton.Enabled = false;
      }
    }

    private void ButtonSetInterval_Click(object sender, EventArgs e)
    {
      timer1.Interval = (int)numericUpDown1.Value * 10;
    }

    private void StartToolStripMenuItem_Click(object sender, EventArgs e)
    {
      StartButton_Click(sender, e);
    }

    private void QuitterToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }

    private void RestartToolStripMenuItem_Click(object sender, EventArgs e)
    {
      RestartButton_Click(sender, e);
    }

    private void PopulateToolStripMenuItem1_Click(object sender, EventArgs e)
    {
      ButtonPopulate_Click(sender, e);
    }
  }
}
