using System.Diagnostics;
using System.Drawing;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using TimeTabler.Models;
using Color = TimeTabler.Models.Color;
using DayOfWeek = TimeTabler.Models.DayOfWeek;

namespace TimeTabler.Components.Pages
{
    public partial class Home
    {
        private bool CreateDialogOpened { get; set; } = false;

        private TaskModel TaskCreated { get; set; } = new TaskModel();
        private BlockModel BlockCreated { get; set; } = new BlockModel();
        private GroupModel GroupCreated { get; set; } = new GroupModel();

        private ScheduleItemType SelectedType { get; set; } = ScheduleItemType.Task;

        private List<TaskModel> Tasks { get; set; } = new List<TaskModel>()
        {
            new()
            {
                Title = "Task 1",
                StartTime = new TimeOnly(8, 0),
                EndTime = new TimeOnly(9, 15),
                Date = new DateOnly(2024,1,10)
            },
            new()
            {
                Title = "Task 3",
                StartTime = new TimeOnly(10, 0),
                EndTime = new TimeOnly(17, 30),
                Date = new DateOnly(2024,1,2)
            },
            new()
            {
                Title = "Task 2",
                StartTime = new TimeOnly(18, 0),
                EndTime = new TimeOnly(19, 0),
                Date = new DateOnly(2024,1,3)
            },
        };

        private List<BlockModel> Blocks { get; set; } = new List<BlockModel>()
        {
            new()
            {
                Title = "Block 1",
                StartTime = new TimeOnly(10, 0),
                EndTime = new TimeOnly(11, 15),
                Date = new DateOnly(2024,1,10)
            },
            new()
            {
                Title = "Block 3",
                StartTime = new TimeOnly(10, 0),
                EndTime = new TimeOnly(17, 30),
                Date = new DateOnly(2024,1,2)
            },
            new()
            {
                Title = "Block 2",
                StartTime = new TimeOnly(18, 0),
                EndTime = new TimeOnly(19, 0),
                Date = new DateOnly(2024,1,3)
            },
        };

        private List<GroupModel> Groups { get; set; } = new List<GroupModel>()
        {
            new GroupModel()
            {
                Name = "Group 1",
            },
            new GroupModel()
            {
                Name = "Group 2",
            },
            new GroupModel()
            {
                Name = "Group 3",
            }
        };

        public List<Color> DefaultColors { get; set; } = new List<Color>()
        {
            new("#CE4444"),
            new("#CE6544"),
            new("#CEC844"),
            new("#89CE44"),
            new("#47CE44"),
            new("#44CE83"),
            new("#44ADCE"),
            new("#4462CE"),
            new("#5744CE"),
            new("#BB44CE"),
            new("#CE4476"),
        };

        private void CreateTask(EditContext context)
        {
            Tasks.Add(TaskCreated);
            TaskCreated = new TaskModel();
            CreateDialogOpened = false;
        }

        private void CreateBlock(EditContext context)
        {
            Blocks.Add(BlockCreated);
            BlockCreated = new BlockModel();
            CreateDialogOpened = false;
        }

        private void CreateGroup(EditContext context)
        {
            Groups.Add(GroupCreated);
            GroupCreated = new GroupModel();
            CreateDialogOpened = false;
        }
    }

}
