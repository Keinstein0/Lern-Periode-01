namespace _ELS__Airport_Security
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Random arrangement of test garbage

            Console.WriteLine("Nothing");

            string input = "C:\\Users\\alex\\source\\repos\\[ELS] Airport Security\\[ELS] Airport Security\\Animations\\animation_test.csv";

            Painter p = new Painter() { sourcefile = input };

            while (true)
            {
                p.play_animation(400);
            }
        }
    }

    public class Painter
    {
        public required string sourcefile;
        public void paint_image(string[] image) // Print the Image in lines
        {
            Console.Clear();
            for (int i = 0; i < image.Length; i++) // Print all the lines in order
            {
                Console.WriteLine(image[i]);
            }
        }
        static string[][] get_animation(string filePath) // Imports the Animation from the File
        {
            // Read all lines from the file
            string[] lines = File.ReadAllLines(filePath);

            // Initialize the array
            string[][] result = new string[lines.Length][];

            for (int i = 0; i < lines.Length; i++)
            {
                // Split each line by ;s to get the columns
                string[] values = lines[i].Split(';');

                // Assign the array of values to the array
                result[i] = values;
            }

            return result;
        }
        public void play_animation(int delay) // Plays all the steps of the Animation
        {
            string[][] sourcelist = get_animation(this.sourcefile); // Convert file to list
            for (int i = 0; i < sourcelist.Length; i++)
            {
                this.paint_image(sourcelist[i]); // paint image of the part of the list
                Thread.Sleep(delay);
            }

        }


    }
}
