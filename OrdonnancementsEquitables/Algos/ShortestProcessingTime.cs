﻿using OrdonnancementsEquitables.Models;
using OrdonnancementsEquitables.Jobs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OrdonnancementsEquitables.Algos
{
    public class ShortestProcessingTime : Algorithme<Job>, IMultipleDevices<Job>, IMultipleUsers<Job>, IMultipleDevicesAndUsers<Job>
    { 
        public User<Job>[] Users { get => (User<Job>[])currentUsers.Clone(); }
        public Device<Job>[] Devices { get => (Device<Job>[])currentDevices.Clone(); }

        private User<Job>[] currentUsers;
        private Device<Job>[] currentDevices;

        public override Job[] Execute(Job[] jobs) => Execute(jobs, 1);

        public Job[] Execute(Job[] jobs, int nbDevices)
        {
            currentJobs = jobs.OrderBy(j => j.Time).ToArray();
            currentDevices = new Device<Job>[nbDevices];

            for (int i = 0; i < nbDevices; i++)
                currentDevices[i] = new Device<Job>();

            foreach (Job j in currentJobs)
            {
                Device<Job> d = currentDevices.OrderBy(d => d.TimeReady).FirstOrDefault();
                d.AddJob(j);
            }

            return Jobs;
        }

        public Job[] Execute(User<Job>[] users)
        {
            currentUsers = users;
            Job[] jobs = currentUsers.SelectMany(u => u.Jobs).ToArray();

            return Execute(jobs);
        }

        public Job[] Execute(User<Job>[] users, int nbDevices)
        {
            currentUsers = users;
            Job[] jobs = currentUsers.SelectMany(u => u.Jobs).ToArray();

            return Execute(jobs, nbDevices);
        }
    }
}