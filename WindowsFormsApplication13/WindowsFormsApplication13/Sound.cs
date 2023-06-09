﻿/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace WindowsFormsApplication13
{
    public class Sound
    {
        
        BufferedWaveProvider bufferedWaveProvider = null;
        Dictionary<string, float> noteBaseFreqs = new Dictionary<string, float>()
            {
                { "C", 16.35f },
                { "C#", 17.32f },
                { "D", 18.35f },
                { "Eb", 19.45f },
                { "E", 20.60f },
                { "F", 21.83f },
                { "F#", 23.12f },
                { "G", 24.50f },
                { "G#", 25.96f },
                { "A", 27.50f },
                { "Bb", 29.14f },
                { "B", 30.87f },
            };

        /* public int SelectInputDevice()
         {
             int inputDevice = 0;
             bool isValidChoice = false;
             string[] devices = new string[WaveInEvent.DeviceCount];

             do
             {
                 //Console.Clear();
                 //Console.WriteLine("Please select input or recording device: ");

                // for (int i = 0; i < WaveInEvent.DeviceCount; i++)
                 //{
                  //   string s =(i + ". " + WaveInEvent.GetCapabilities(i).ProductName);
                 //    devices[i] = s; 

                // }

                 //Console.WriteLine();

                 try
                 {
                     if (int.TryParse(Console.ReadLine(), out inputDevice))
                     {
                         isValidChoice = true;
                         Console.WriteLine("You have chosen " + WaveInEvent.GetCapabilities(inputDevice).ProductName + ".\n");
                     }
                     else
                     {
                         isValidChoice = false;
                     }
                 }
                 catch
                 {
                     throw new ArgumentException("Device # chosen is out of range.");
                 }

             } while (isValidChoice == false);

             return inputDevice;
         }*/

        /*  public float StartDetect(int inputDevice)
          {
              WaveInEvent waveIn = new WaveInEvent();

              waveIn.DeviceNumber = inputDevice;
              waveIn.WaveFormat = new WaveFormat(44100, 1);
              waveIn.DataAvailable += WaveIn_DataAvailable;

              bufferedWaveProvider = new BufferedWaveProvider(waveIn.WaveFormat);

              // begin record
              waveIn.StartRecording();

              IWaveProvider stream = new Wave16ToFloatProvider(bufferedWaveProvider);
              Pitch pitch = new Pitch(stream);

              byte[] buffer = new byte[8192];
              int bytesRead;

              //Console.WriteLine("Play or sing a note! Press ESC to exit at any time. \n");

             // do
             // {
                  bytesRead = stream.Read(buffer, 0, buffer.Length);

                  float freq = pitch.Get(buffer);

               //   if (freq != 0)
               //   {
                //      Console.WriteLine("Freq: " + freq + " | Note: " + GetNote(freq));
               //   }

             // } while (bytesRead != 0 && !(Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Escape));

              // stop recording
              waveIn.StopRecording();
              waveIn.Dispose();
              return freq;
          }
       public void FQFInder ()
        {

        }
        public void StartDetect(int inputDevice)
        {
            WaveInEvent waveIn = new WaveInEvent();

            waveIn.DeviceNumber = inputDevice;
            waveIn.WaveFormat = new WaveFormat(44100, 1);
            waveIn.DataAvailable += WaveIn_DataAvailable;

            bufferedWaveProvider = new BufferedWaveProvider(waveIn.WaveFormat);

            // begin record
            waveIn.StartRecording();

            IWaveProvider stream = new Wave16ToFloatProvider(bufferedWaveProvider);
            Pitch pitch = new Pitch(stream);

            byte[] buffer = new byte[8192];
            int bytesRead;

            MessageBox.Show("Play or sing a note! Press ESC to exit at any time. \n");

            do
            {
                bytesRead = stream.Read(buffer, 0, buffer.Length);

                float freq = pitch.Get(buffer);

                if (freq != 0)
                {
                    MessageBox.Show("Freq: " + freq + " | Note: " + GetNote(freq)); 
                }

            } while (bytesRead != 0);

            // stop recording
            waveIn.StopRecording();
            waveIn.Dispose();
        }

        void WaveIn_DataAvailable(object sender, WaveInEventArgs e)
        {
            if (bufferedWaveProvider != null)
            {
                bufferedWaveProvider.AddSamples(e.Buffer, 0, e.BytesRecorded);
                bufferedWaveProvider.DiscardOnBufferOverflow = true;
            }
        }

        public string GetNote(float freq)
        {
            float baseFreq;

            foreach (var note in noteBaseFreqs)
            {
                baseFreq = note.Value;

                for (int i = 0; i < 9; i++)
                {
                    if ((freq >= baseFreq - 0.5) && (freq < baseFreq + 0.485) || (freq == baseFreq))
                    {
                        return note.Key + i;
                    }

                    baseFreq *= 2;
                }
            }

            return null;
        }
    }
}
*/