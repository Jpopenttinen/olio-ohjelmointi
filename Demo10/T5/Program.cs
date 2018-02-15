using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace T5
{
    class TVprog
    {
        public string Name { get; set; }
        public string Channel { get; set; }
        public string Info { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public TVprog(string name, string channel, string info, DateTime startTime, DateTime endTime)
        {
            Name = name;
            Channel = channel;
            Info = info;
            StartTime = startTime;
            EndTime = endTime;
        }
        public override string ToString()
        {
            return "Name: " + Name + ", Channel: " + Channel + ", StartTime: " + StartTime + ", EndTime: " + EndTime + ", Info: " + Info;
        }
    }
    class TVCreation
    {
        private const string DATA_FILENAME = @"Z:\Olio-ohjelmointi\friendsinformation.dat";
        public BinaryFormatter formatter;
        public List<TVprog> Programs;

        public void Save()
        {
            // Gain code access to the file that we are going
            // to write to

            try
            {
                // Create a FileStream that will write data to file.
                FileStream writerFileStream =
                    new FileStream(DATA_FILENAME, FileMode.Create, FileAccess.Write);
                // Save our dictionary of friends to file
                this.formatter.Serialize(writerFileStream, this.Programs);

                // Close the writerFileStream when we are done.
                writerFileStream.Close();
            }
            catch (Exception)
            {
                Console.WriteLine("Unable to save our TV information");
            } // end try-catch
        } // end public bool Load()
        public void Load()
        {

            // Check if we had previously Save information of our friends
            // previously
            if (File.Exists(DATA_FILENAME))
            {

                try
                {
                    // Create a FileStream will gain read access to the 
                    // data file.
                    FileStream readerFileStream = new FileStream(DATA_FILENAME,
                        FileMode.Open, FileAccess.Read);
                    // Reconstruct information of our friends from file.
                    this.Programs = (List<TVprog>)
                        this.formatter.Deserialize(readerFileStream);
                    // Close the readerFileStream when we are done
                    readerFileStream.Close();

                }
                catch (Exception)
                {
                    Console.WriteLine("There seems to be a file that contains " +
                        "friends information but somehow there is a problem " +
                        "with reading it.");
                } // end try-catch

            } // end if

        } // end public bool Load()

        public void Print()
        {
            // If we have saved information about friends
            if (this.Programs.Count > 0)
            {
                Console.WriteLine("Name, Email");
                foreach (TVprog prog in this.Programs)
                {
                    Console.WriteLine(prog);
                } // end foreach
            }
            else
            {
                Console.WriteLine("There are no saved information about your friends");
            } // end if
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            DateTime Start = new DateTime(2018, 3, 1, 7, 0, 0);
            DateTime End = new DateTime(2018, 3, 1, 7, 0, 5);


            TVprog PrisonBreak = new TVprog("Prison Break", "abc", "Guy breaks out of jail", Start, End);
            TVprog SexAndTheCity = new TVprog("Sex And City", "Fox", "Guy breaks to jail", Start, End);
            TVprog ModernFamily = new TVprog("Modern Family", "abc", "Nothing", Start, End);

            List<TVprog> Programs = new List<TVprog>();
            Programs.Add(PrisonBreak);
            Programs.Add(SexAndTheCity);
            Programs.Add(ModernFamily);

            
            TVCreation newTV = new TVCreation();

            newTV.formatter = new BinaryFormatter();

            newTV.Save();
            newTV.Load();
            newTV.Print();

        }

    }
        
}
