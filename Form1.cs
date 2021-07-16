using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FirstApp
{
    public partial class Form1 : Form
       
    {
      public static Schuduler schuduler1;
       public class Schuduler
        {
           public List<string> processName = new List<string>();
           public List<float>processDuration = new List<float>();
           public Process[] tasks = new Process[100];
           public int quantum;
            public float avgTime;
           public Schuduler()
            {
                for (int i = 0; i < 100; i++)
                {
                    tasks[i] = new Process();
                    
                }
            }
            public void FCFS()
            {
                int i, j;
                Process temp;
                for (i = 0; i < Form1.i; i++)
                {
                    for (j = 0; j < Form1.i - 1; j++)
                    {
                        if (tasks[j].arrival > tasks[j + 1].arrival)
                        {
                            temp = tasks[j];
                            tasks[j] = tasks[j + 1];
                            tasks[j + 1] = temp;
                        }
                    }
                }
                tasks[0].ProcessWaiting = 0;
                float sum=0;
                for (i = 1; i < Form1.i; i++)
                {
                    tasks[i].ProcessWaiting = tasks[i - 1].burst + tasks[i - 1].ProcessWaiting;
                    sum += tasks[i].ProcessWaiting;
                }
                avgTime = sum/Form1.i;
                for (i = 0; i < Form1.i; i++)
                {
                    tasks[i].ProcessTurnaround = tasks[i].burst + tasks[i].ProcessWaiting;
                }
                //processDuration.Add(tasks[0].arrival);
              
                for (i = 0; i < Form1.i; i++)
                {
                    processName.Add(tasks[i].name);
                    processDuration.Add(tasks[i].burst);
                }
            }
            public void SJF()
            {
                string[] tempName = new string[100];
                float[] tempDuration = new float[100];

                int flag = 1;
                int flag2 = 1;
                int m = 0;
                int index = 0;
                float min = 10000000;
                float currenttime = 0;
                int s = Form1.i;
                float awt = 0F;
                float[] wt = new float[30];
                int[] is_completed = new int[30];
                
                float[] start = new float[60];
                float[] end = new float[60];
                float t;
                string temp;
                for (var i = 0; i < Form1.i; i++)
                {
                    
                    is_completed[i] = 0;
                    if (i > 0)
                    {
                        if (tasks[i].arrival != tasks[i-1].arrival)
                        {
                            flag = 0;
                        }
                    }
                }
                if (flag == 1)
                {
                    for (var i = 0; i < Form1.i; i++)
                    {
                        for (var j = 0; j < Form1.i - i - 1; j++)
                        {
                            if (tasks[j].burst > tasks[j + 1].burst)
                            {
                                t = tasks[j].burst;
                                tasks[j].burst = tasks[j+1].burst;
                                tasks[j+1].burst = t;

                                temp = tasks[j].name;
                                tasks[j].name = tasks[j+1].name;
                                tasks[j+1].name = temp;
                            }
                        }
                    }
                    if (tasks[0].arrival != 0)
                    {
                        tempName[0]="0";
                        start[0] = 0;
                        end[0] = tasks[0].arrival;
                        wt[0] = 0;
                        flag2 = 0;
                        m++;
                        s++;
                    }
                    else
                    {
                        tempName[0]=tasks[0].name;
                        start[0] = tasks[0].arrival;
                        end[0] = start[0] + tasks[0].burst;
                        m++;
                    }
                    for (var i = 0; i < Form1.i; i++)
                    {
                        if (flag2 == 1 && i == 0)
                        {
                            continue;
                        }
                        tempName[m] = tasks[i].name;
                        start[m] = end[m - 1];
                        end[m] = start[m] + tasks[i].burst;
                        wt[m - 1] = start[m] - tasks[i].arrival;//here
                        m++;

                    }
                }
                else
                {
                    for (var i = 0; i < Form1.i; i++)
                    {
                        for (var j = 0; j < Form1.i - i - 1; j++)
                        {
                            if (tasks[j].arrival > tasks[j+1].arrival)
                            {
                                t = tasks[j].burst;
                                tasks[j].burst = tasks[j+1].burst;
                                tasks[j+1].burst = t;

                                temp = tasks[j].name;
                                tasks[j].name = tasks[j+1].name;
                                tasks[j+1].name = temp;

                                t = tasks[j].arrival;
                                tasks[j].arrival = tasks[j+1].arrival;
                                tasks[j+1].arrival = t;
                            }
                        }
                    }
                    if( tasks[0].arrival != 0)
                    {
                        tempName[0] = "0";
                        start[0] = 0;
                        end[0] = tasks[0].arrival;
                        flag2 = 0;
                        m++;
                        s++;
                    }
                    else
                    {
                        tempName[0] = tasks[0].name;
                        start[0] = tasks[0].arrival;
                        end[0] = start[0] + tasks[0].burst;
                        is_completed[0] = 1;
                        currenttime = end[0];
                        m++;
                    }
                    for (var i = 0; i < Form1.i; i++)
                    {
                        if (flag2 == 1 && i == 0)
                        {
                            if (tasks[index].burst < (tasks[i + 1].arrival - tasks[i].arrival))
                            {

                                tempName[m] = "0";
                                start[m] = end[m - 1];
                                end[m] = tasks[i + 1].arrival;
                                is_completed[index] = 1;
                                currenttime = end[m];
                                m++;
                                s++;
                            }
                            else
                            {
                                continue;
                            }
                        }
                        else if (flag2 == 0 && i == 0)
                        {
                            tempName[1] = tasks[0].name;
                            start[1] = tasks[0].arrival;
                            if(tasks[index].burst < (tasks[i + 1].arrival - tasks[i].arrival))
                            {
                                tempName[m] = tasks[index].name;
                                end[m] = tasks[index].burst + start[m];
                                m++;
                                tempName[m] = "0";
                                start[m] = end[m - 1];
                                end[m] = tasks[i + 1].arrival;
                                is_completed[index] = 1;
                                currenttime = end[m];
                                m++;
                                s++;
                            }
                            else
                            {
                                end[1] = start[1] + tasks[index].burst;
                                is_completed[index] = 1;
                                currenttime = end[m];
                                m++;
                            }
                        }
                        else
                        {
                            min = 10000000;
                            for (var j = 0; j < Form1.i; j++)
                            {
                                if (currenttime < tasks[j].arrival || is_completed[j] == 1)
                                {
                                    continue;
                                }
                                else if (tasks[j].burst < min)
                                {
                                    min = tasks[j].burst;
                                    index = j;
                                }


                            }
                            tempName[m] = tasks[index].name;
                            start[m] = end[m - 1];
                            end[m] = start[m] + tasks[index].burst;
                            is_completed[index] = 1;
                            currenttime = end[m];
                            m++;
                        }
                    }
                }
                for (int i = 0; i < Form1.i; i++)//here
                {
                    awt = awt + wt[i];
                }
                avgTime = awt / Form1.i;//here
                for (var i = 0; i < s; i++)
                {
                    tempDuration[i] = end[i] - start[i];
                    
                }
                for (int i = 0; i < Form1.i; i++)
                {
                    processName.Add(tempName[i]);
                    processDuration.Add(tempDuration[i]);
                }
            }
            public void SRTF()
            {
                string[] tempName = new string[100];
                float[] tempDuration = new float[100];
                int m = 0;
                int z = 0;
                float min;
                float min2 = 10000000;
                int s = (2 * Form1.i) - 1;
                float current_time = 0;
                int completed = 0;
                int k = 2;
                int index;
                int index2 = 0;
                int flag = 0;
                float awt = 0F;
                float[] endf = new float[30];
                int[] is_completed = new int[30];
               
              
                float[] rt = new float[30];
                
                float[] start = new float[60];
                float[] end = new float[60];
                float[] wt = new float[30];
                string temp;
                float t;
                for (var i = 0; i < Form1.i; i++)
                {
                    is_completed[i] = 0;
                    wt[i] = 0;
                    endf[i] = 0;
                    rt[i] = tasks[i].burst;
                }
                for (var i = 0; i < Form1.i; i++)
                {
                    for (var j = 0; j < Form1.i - i - 1; j++)
                    {
                        if (tasks[j].arrival > tasks[j+1].arrival)
                        {
                            t = tasks[j].burst;
                            tasks[j].burst = tasks[j + 1].burst;
                            tasks[j + 1].burst = t;

                            temp = tasks[j].name;
                            tasks[j].name = tasks[j + 1].name;
                            tasks[j + 1].name = temp;

                            t = tasks[j].arrival;
                            tasks[j].arrival = tasks[j + 1].arrival;
                            tasks[j + 1].arrival = t;

                            t = rt[j];
                            rt[j] = rt[j + 1];
                            rt[j + 1] = t;
                        }
                    }
                }
                if (tasks[0].arrival != 0)
                {
                    tempName[0] = "0";
                    start[0] = 0;
                    end[0] = tasks[0].arrival;
                    flag = 1;
                    m++;
                    s++;
                }
                else
                {
                    tempName[0] = tasks[0].name;
                    start[0] = tasks[0].arrival;
                    m++;
                }
                index = 0;
                for (var i = 0; i < Form1.i; i++)
                {
                    if (flag == 0 && i == 0)
                    {
                        if (rt[index] < (tasks[i+1].arrival - tasks[i].arrival))
                        {
                            tempName[m] = tasks[index].name;
                            end[m] = rt[index] + start[m];
                            endf[index] = end[m];
                            wt[index] = 0;//here
                            m++;
                            tempName[m] = "0";
                            start[m] = end[m - 1];
                            end[m] = tasks[i + 1].arrival;
                            is_completed[index] = 1;
                            completed++;
                            m++;
                        }
                        else
                        {
                            continue;
                        }

                    }
                    else if (flag == 1 && i == 0)
                    {
                        tempName[1] = tasks[0].name;
                        start[1] = tasks[0].arrival;
                        if (rt[index] < (tasks[i + 1].arrival - tasks[i].arrival))
                        {
                            tempName[m] = tasks[index].name;
                            end[m] = rt[index] + start[m];
                            m++;
                            tempName[m] = "0";
                            start[m] = end[m - 1];
                            end[m] = tasks[i + 1].arrival;
                            is_completed[index] = 1;
                            completed++;

                            m++;


                        }
                        else
                        {
                            end[1] = tasks[1].arrival;
                            m++;
                        }

                    }
                    else
                    {


                        rt[index] = rt[index] - (tasks[i].arrival - tasks[i - 1].arrival);


                        current_time = tasks[i].arrival;
                        end[m - 1] = tasks[i].arrival;
                        start[m] = tasks[i].arrival;
                        endf[index] = end[m - 1];//here
                        min = 10000000;
                        min2 = 10000000;
                        for (var j = 0; j < k; j++)
                        {
                            if (rt[j] < min && rt[j] > 0)
                            {
                                min2 = min;
                                index2 = index;
                                min = rt[j];
                                index = j;
                            }
                            if (rt[j] > min && rt[j] < min2 && rt[j] > 0)
                            {
                                min2 = rt[j];
                                index2 = j;
                            }
                        }
                        k++;
                        if (i != Form1.i - 1 && rt[index] < (tasks[i+1].arrival - tasks[i].arrival))
                        {


                            if (min2 != 10000000)
                            {

                                tempName[m] = tasks[index].name;
                                end[m] = start[m] + rt[index];
                                is_completed[index] = 1;
                                tasks[i].arrival = tasks[i].arrival + rt[index];
                                m++;
                                index = index2;
                                tempName[m] = tasks[index].name;
                                start[m] = end[m - 1];
                                end[m] = tasks[i + 1].arrival;

                                completed++;
                                m++;

                            }

                        }
                        else if (i != Form1.i - 1 && rt[index] == (tasks[i+1].arrival - tasks[i].arrival))
                        {
                            is_completed[index] = 1;
                            completed++;
                            tempName[m] = tasks[index].name;
                            start[m] = tasks[i].arrival;
                            end[m] = rt[index] + tasks[i].arrival;
                            m++;
                        }
                        else
                        {
                            tempName[m] = tasks[index].name;
                            end[m] = rt[index] + tasks[i].arrival;
                            if (endf[index] == 0)//here

                            {
                                wt[index] = wt[index] + (start[m] - tasks[index].arrival);


                            }
                            else
                            {
                                wt[index] = wt[index] + (start[m] - endf[index]);
                            }
                            m++;
                        }
                        if (i == Form1.i - 1)
                        {
                            rt[index] = 0;
                            z++;
                            
                        }

                    }


                }
                float x;
                for (var i = 0; i < Form1.i; i++)
                {
                    for (var j = 0; j < Form1.i - i - 1; j++)
                    {
                        if (is_completed[j] > is_completed[j + 1])
                        {
                            t = rt[j];
                            rt[j] = rt[j + 1];
                            rt[j + 1] = t;
                            temp = tasks[j].name;
                            tasks[j].name = tasks[j + 1].name;
                            tasks[j + 1].name = temp;

                            x = endf[j];//here
                            endf[j] = endf[j + 1];
                            endf[j + 1] = x;


                            x = wt[j];//here
                            wt[j] = wt[j + 1];
                            wt[j + 1] = x;
                            t = tasks[j].arrival;//here
                            tasks[j].arrival = tasks[j+1].arrival;
                            tasks[j+1].arrival = t;
                        }
                    }
                }
                for (var i = 0; i < (Form1.i - completed); i++)
                {
                    for (var j = 0; j < (Form1.i - completed) - i - 1; j++)
                    {
                        if (rt[j] > rt[j + 1])
                        {
                            t = rt[j];
                            rt[j] = rt[j + 1];
                            rt[j + 1] = t;

                            temp = tasks[j].name;
                            tasks[j].name = tasks[j + 1].name;
                            tasks[j + 1].name = temp;
                            x = endf[j];//here
                            endf[j] = endf[j + 1];
                            endf[j + 1] = x;


                            x = wt[j];//here
                            wt[j] = wt[j + 1];
                            wt[j + 1] = x;
                            t = tasks[j].arrival;//here
                            tasks[j].arrival = tasks[j + 1].arrival;
                            tasks[j + 1].arrival = t;

                        }
                    }
                }

                for (var i = 0; i < (Form1.i - completed); i++)
                {
                    tempName[m] = tasks[z].name;
                    start[m] = end[m - 1];
                    end[m] = rt[z] + start[m];
                    if (endf[z] == 0)//here
                    {
                        wt[z] = wt[z] + (start[m] - tasks[z].arrival);


                    }
                    else
                    {
                        wt[z] = wt[z] + (start[m] - endf[z]);
                    }
                    z++;
                    m++;
                }

                for (int i = 0; i < Form1.i; i++)//here
                {
                    awt = awt + wt[i];
                }
                avgTime = awt / Form1.i;

                for (var i = 0; i < s; i++)
                {
                    tempDuration[i] = end[i] - start[i];
                    
                }
                for (int i = 0; i < s; i++)
                {
                    processDuration.Add(tempDuration[i]);
                    processName.Add(tempName[i]);
                }
            }
            public void RoundRobin()
            {
                string[] chart = new string[100];
                int chart_length = 0;
                float sumOfArrivalTime = 0;
                for (int i = 1; i < Form1.i; i++)
                {
                    sumOfArrivalTime += tasks[i].arrival;
                }

                void RR(int time_quantum, Process[] plist, int n)
                {
                    Process[] queu = new Process[100];
                    int queu_length = 0;


                    for (int i = 0; i < 100; i++)
                    {
                        queu[i] = new Process();
                    }


                    float time = 0;
                    int arrival_process = 0;
                    int ready_process = 0;
                    int done = 0;
                    int start = 0;

                    while (done < n)
                    {
                        for (int i = arrival_process; i < n; i++)
                        {

                            if (time >= plist[i].arrival)
                            {
                                queu[i] = plist[i];
                                queu_length += 1;
                                arrival_process += 1;
                                ready_process += 1;
                            }

                        }

                        if (ready_process < 1)
                        {
                            time += 1;
                            continue;
                        }


                        if (start == 1)
                        {
                            Process temp = new Process();
                            temp = queu[0];
                            for (int i = 0; i < queu_length - 1; i++) { queu[i] = queu[i + 1]; }
                            queu[queu_length - 1] = temp;
                        }



                        if (queu[0].burst > 0)
                        {
                            if (queu[0].burst > time_quantum)
                            {
                                for (int i = Convert.ToInt32(time); i < Convert.ToInt32(time) + time_quantum; i++)
                                {
                                    chart[i] = queu[0].name;
                                    chart_length += 1;
                                }

                                time += time_quantum;
                                queu[0].burst -= time_quantum;
                            }
                            else
                            {
                                for (int i = Convert.ToInt32(time); i < Convert.ToInt32(time) + queu[0].burst; i++)
                                {
                                    chart[i] = queu[0].name;
                                    chart_length += 1;
                                }

                                time += queu[0].burst;
                                queu[0].burst = 0;
                                done += 1;
                                ready_process -= 1;
                            }

                            start = 1;
                        }



                    }


                }
                int timer_counter = 0;
                int[] timer = new int[100];

                for (int i = 0; i < 100; i++)
                {
                    timer[i] = 0;
                }
                int timer_length = 1;
                string[] process_gantt = new string[100];

                int process_gantt_length = 1;

                

                RR(quantum,tasks, Form1.i);

                for (int i = 0; i < chart_length; i++)
                {
                    timer_counter++;
                    if (i > 0)
                    {
                        if (chart[i] != chart[i - 1])
                        {
                            process_gantt[process_gantt_length] = chart[i];
                            process_gantt_length += 1;
                            timer[timer_length] = timer_counter - 1;

                            timer_length += 1;
                        }
                    }

                }
                timer[timer_length] = timer_counter;
                timer_length += 1;
                process_gantt[0] = chart[0];
                List<string>tempName = new List<string>();
                List<float> tempDuration = new List<float>();
                for (int i = 1; i < timer_length; i++)
                {
                    tempDuration.Add(timer[i] - timer[i - 1]);
                    tempName.Add(process_gantt[i - 1]); 
                }
                float sum;
                int count = 0;
                for (int i = 0; i < tempDuration.Count; i++)
                {
                    sum = tempDuration[i];
                    while (sum>quantum)
                    {
                        processName.Add(tempName[i]);
                        processDuration.Add(quantum);
                        sum -= quantum;
                        count++;
                       
                    }
                    if (sum <= quantum && sum > 0)
                    {

                        processName.Add(tempName[i]);
                        processDuration.Add(sum);
                        count++;
                    }
                }
                float sumOfStartTime = 0;
                float s = 0;
                for (int i = 0; i < (Form1.i-1); i++)
                {
                    s += processDuration[i];
                    sumOfStartTime += s;
                }
                avgTime = (sumOfStartTime - sumOfArrivalTime)/Form1.i;
                Console.WriteLine(avgTime);
            }
            public void Priority(bool preemtive)
            {
                

                int clock = -1;// system's global clock

                List<Job> jobs = new List<Job>();
                List<int> timeSeries = new List<int>();

                Dictionary<int, float> waiting = new Dictionary<int, float>();

                List<String> processesNames = new List<string>();
                List<float> processesTime = new List<float>();

                

                //taking the processes
                for (int i = 0; i < Form1.i; i++)
                {
                    
                    Job job = new Job();
                    job.pid = Convert.ToInt32(tasks[i].name.Substring(1));
                    job.priority = tasks[i].priority;
                    job.arrivalTime = tasks[i].arrival;
                    job.burstTime = tasks[i].burst;
                    jobs.Add(job);

                }
                JobQ jobsQ = new JobQ(jobs);
                ReadyQ readyQ = new ReadyQ();
                Processor Core = new Processor();

                while (jobsQ.getSize() != 0 || readyQ.getSize() != 0 || (Core.running_job != null && Core.running_job.burstTime > 0))
                {
                    clock++;
                    while (jobsQ.peak() != null && (int)Math.Round(jobsQ.peak().arrivalTime) == clock)
                    {
                        Job job = jobsQ.getJob();
                        readyQ.addJob(job);
                    }
                    if (preemtive)
                    {
                        if (readyQ.peak() != null && Core.checkJobPreemptive(readyQ.peak()) && readyQ.getSize() != 0)
                        {
                            Core.setJob(readyQ.getJob());
                            if (Core.getJob() != null)
                            {
                                readyQ.addJob(Core.getJob());
                            }
                        }
                    }else
                    {
                        if (readyQ.peak() != null && Core.checkJobNonPreemptive(readyQ.peak()) && readyQ.getSize() != 0)
                        {
                            Core.setJob(readyQ.getJob());
                            if (Core.getJob() != null)
                            {
                                readyQ.addJob(Core.getJob());
                            }
                        }
                    }
                    

                    Core.run();
                    if (Core.running_job != null)
                    {
                        timeSeries.Add(Core.running_job.pid);
                    }

                    foreach (Job job in readyQ.jobs)
                    {
                        if (waiting.ContainsKey(job.pid))
                        {
                            waiting[job.pid] += 1;
                        }
                        else
                        {
                            waiting.Add(job.pid, 1);
                        }
                    }
                }
                float avg = 0;
                foreach (int val in waiting.Values)
                {
                    avg += val;
                }

                avg = avg / Form1.i;

                avgTime = avg;
                float time = 0;
                for (int i = 0; i < timeSeries.Count; i++)
                {
                    if (i < timeSeries.Count - 1 && timeSeries[i] != timeSeries[i + 1])
                    {
                        time++;
                        processesNames.Add("P" + Convert.ToString(timeSeries[i]));
                        processesTime.Add(time);
                        time = 0;
                    }
                    else if (i == timeSeries.Count - 1)
                    {
                        time++;
                        processesNames.Add("P" + Convert.ToString(timeSeries[i]));
                        processesTime.Add(time);
                        time = 0;
                    }
                    else
                    {
                        time++;
                    }
                }
                
                for (int i = 0; i < processesNames.Count; i++)
                {
                    processDuration.Add(processesTime[i]);
                    processName.Add(processesNames[i]);
                }
                
            }

        }
        public class Process
        {
            public string name;
            public float arrival;
            public float burst;
            public int priority;
            float turnaround, waiting;
            public float ProcessTurnaround
            {
                get { return turnaround; }
                set { turnaround = value; }
            }
            public float ProcessWaiting
            {
                get { return waiting; }
                set { waiting = value; }
            }
        }
        class Job
        {
            public int pid;
            public int priority;
            public float arrivalTime;
            public float burstTime;
        }

        class JobQ
        {
            List<Job> jobs;

            public JobQ(List<Job> outJobs)
            {
                //this.jobs = (List<Job>)outJobs.OrderByDescending(o => o.arrivalTime);
                outJobs.Sort(delegate (Job x, Job y)
                {
                    return y.arrivalTime.CompareTo(x.arrivalTime);
                }
                    );

                this.jobs = outJobs;

            }

            public int getSize()
            {
                return this.jobs.Count;
            }

            public Job getJob()
            {
                if (this.getSize() == 0) return null;
                else
                {
                    Job job = this.jobs[this.jobs.Count - 1];
                    this.jobs.RemoveAt(this.jobs.Count - 1);
                    return job;
                }
            }

            public Job peak()
            {
                if (this.getSize() == 0) return null;
                else
                {
                    Job job = this.jobs[this.jobs.Count - 1];
                    return job;
                }
            }

        }

        class ReadyQ
        {
            public List<Job> jobs;

            public ReadyQ()
            {
                this.jobs = new List<Job>();
            }

            public int getSize()
            {
                return this.jobs.Count;
            }

            public Job peak()
            {
                if (this.getSize() == 0) return null;
                else
                {
                    Job job = this.jobs[this.jobs.Count - 1];
                    return job;
                }
            }

            public Job getJob()
            {
                if (this.getSize() == 0) return null;
                else
                {
                    Job job = this.jobs[this.jobs.Count - 1];
                    this.jobs.RemoveAt(this.jobs.Count - 1);
                    return job;
                }
            }

            public void addJob(Job job)
            {
                this.jobs.Add(job);
                //this.jobs = (List<Job>)jobs.OrderByDescending(o => o.priority);
                this.jobs.Sort(delegate (Job x, Job y)
                {
                    return y.priority.CompareTo(x.priority);
                }
                );
            }

        }

        class Processor
        {
            public Job running_job;
            public Job idle_job;

            public Processor()
            {
                this.running_job = null;
                this.idle_job = null;
            }

            public void setJob(Job job)
            {
                this.running_job = job;
            }

            public Job getJob()
            {
                if (this.idle_job == null) return null;
                else if (this.idle_job.burstTime < 1) return null;
                else return this.idle_job;
            }

            public void run()
            {
               if (this.running_job == null)
                  /*donoting*/  ;
                else if (this.running_job.burstTime < 1) this.running_job = null;
                else this.running_job.burstTime--;
            }

            public bool checkJobPreemptive(Job job)
            {
                if (this.running_job == null || this.running_job.priority > job.priority || this.running_job.burstTime < 1)
                {
                    this.idle_job = this.running_job;
                    this.running_job = job;
                    return true;
                }
                else return false;
            }
            public bool checkJobNonPreemptive(Job job)
            {
                if (this.running_job == null|| this.running_job.burstTime < 1)
                {
                    this.idle_job = this.running_job;
                    this.running_job = job;
                    return true;
                }
                else return false;
            }


        }

        public static int i = 0;
        public Form1()
        {
            InitializeComponent();
            
        }

           


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
        }

        private void process1_Exited(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            schuduler1 = new Schuduler();
            algo.Text = "FCFS";
        }
        

      

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (algo.SelectedIndex == 0)
                FCFS_Algo(false);
            else if (algo.SelectedIndex == 2)
            {
                RB_Algo(false);
                quantum.Text = "";
            }
            else if (algo.SelectedIndex == 1)
            {
                SJF_SRTF_Algo(false);

            }
            else if (algo.SelectedIndex == 3)
            {
                Priority_Algo(false);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            test.Text = name.Text;

            try
            {
                if (algo.SelectedIndex == 0)
                {
                    FCFS_Algo(true);

                    name.Text = "";
                    arrival.Text = "";
                    burst.Text = "";
                    quantum.Text = "No Input Allowed";
                    priority.Text = "No Input Allowed";
                }
                else if (algo.SelectedIndex == 2)
                {
                    RB_Algo(true);

                    name.Text = "";
                    arrival.Text = "";
                    burst.Text = "";
                    priority.Text = "No Input Allowed";
                }
                else if (algo.SelectedIndex == 1)
                {
                    SJF_SRTF_Algo(true);
                    if (preemtive.Checked)
                        non_preemtive.Enabled = false;
                    else
                        preemtive.Enabled = false;

                    name.Text = "";
                    arrival.Text = "";
                    burst.Text = "";
                    quantum.Text = "No Input Allowed";
                    priority.Text = "No Input Allowed";
                }
                else if (algo.SelectedIndex == 3)
                {
                    Priority_Algo(true);
                    quantum.Text = "No Input Allowed";
                    if (preemtive.Checked)
                        non_preemtive.Enabled = false;
                    else
                        preemtive.Enabled = false;

                    name.Text = "";
                    arrival.Text = "";
                    burst.Text = "";
                    quantum.Text = "No Input Allowed";
                    priority.Text = "";
                }
                algo.Enabled = false;

            }catch
            {
                MessageBox.Show("Wrong Input!");
            }


            

            i++;
        }
        void FCFS_Algo(bool change)
        {
            if (change)
            {
                schuduler1.tasks[i].name = name.Text;
                schuduler1.tasks[i].burst = float.Parse(burst.Text);
                schuduler1.tasks[i].arrival = float.Parse(arrival.Text);
            }
            quantum.Enabled = false;
            priority.Enabled = false;
            preemtive.Enabled = false;
            non_preemtive.Checked = true;
            quantum.Text = "No Input Allowed";
            priority.Text = "No Input Allowed";
        }
        void RB_Algo(bool change)
        {
            if (change)
            {
                schuduler1.tasks[i].name = name.Text;
                schuduler1.tasks[i].burst = float.Parse(burst.Text);
                schuduler1.tasks[i].arrival = float.Parse(arrival.Text);
                schuduler1.quantum = int.Parse(quantum.Text);
            }
          
            

            priority.Enabled = false;
            non_preemtive.Enabled = false;
            preemtive.Enabled = true;
            preemtive.Checked = true;
            quantum.Enabled = true;
            
            priority.Text = "No Input Allowed";
        }
        void SJF_SRTF_Algo(bool change)
        {
            if (change)
            {
                schuduler1.tasks[i].name = name.Text;
                schuduler1.tasks[i].burst = float.Parse(burst.Text);
                schuduler1.tasks[i].arrival = float.Parse(arrival.Text);
            }
            
            preemtive.Enabled = true;
            non_preemtive.Enabled = true;
            priority.Enabled = false;
            quantum.Enabled = false;
            quantum.Text = "No Input Allowed";
            priority.Text = "No Input Allowed";
        }
        void Priority_Algo(bool change)
        {
            if (change)
            {
                schuduler1.tasks[i].name = name.Text;
                schuduler1.tasks[i].burst = float.Parse(burst.Text);
                schuduler1.tasks[i].arrival = float.Parse(arrival.Text);
                schuduler1.tasks[i].priority = int.Parse(priority.Text);
            }

            preemtive.Enabled = true;
            non_preemtive.Enabled = true;
            priority.Enabled = true;
            quantum.Enabled = false;
            quantum.Text = "No Input Allowed";
            priority.Text = "";
        }
        private void priority_Validated(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (algo.SelectedIndex == 0)
                schuduler1.FCFS();
            else if (algo.SelectedIndex == 2)
                schuduler1.RoundRobin();
            else if (algo.SelectedIndex == 1)
            {
                if (preemtive.Checked)
                    schuduler1.SRTF();
                else
                    schuduler1.SJF();
            }
            else if (algo.SelectedIndex == 3)
            {
                if (preemtive.Checked)
                    schuduler1.Priority(true);
                else
                    schuduler1.Priority(false);
            }
            Form2 newform = new Form2();
            this.Hide();
            newform.ShowDialog();
            this.Show();
        }

        private void algo_ChangeUICues(object sender, UICuesEventArgs e)
        {

            //if(algo.SelectedIndex == 1)

        }

        private void non_preemtive_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            name.Text = "";
            arrival.Text = "";
            burst.Text = "";
            if(quantum.Text != "No Input Allowed")
                quantum.Text = "";
            if (priority.Text != "No Input Allowed")
                priority.Text = "";
           
        }


        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void clearAll_Click(object sender, EventArgs e)
        {
            for(int j=0;j<i;j++)
            {
                schuduler1.tasks[j].name = "";
                schuduler1.tasks[j].arrival = 0;
                schuduler1.tasks[j].burst = 0;
                schuduler1.tasks[j].priority = 0;
                schuduler1.quantum = 0;
                
            }
            i = 0;
            algo.Enabled = true;
            test.Text = "";
        }

        private void preemtive_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
        
