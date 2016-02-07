using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class MazeCell
    {
        public MazeCell PreviousBuildCell { get; set; }
        public MazeDirection PreviousBuildDirection { get; set; }
        public MazeCell PreviousExploreCell { get; set; }
        public MazeDirection PreviousExploreDirection { get; set; }

        public IEnumerable<MazeDirection> BuildDirections { get; set; }
        public IEnumerable<MazeDirection> ExploreDirections { get; set; }

        public int X { get; set; }
        public int Y { get; set; }

        public bool CanContinueBuild
        {
            get
            {
                return BuildDirections.Count() > 0;
            }
        }

        public bool CanContinueExplore
        {
            get
            {
                return ExploreDirections.Count() > 0;
            }
        }

        public bool HasPath { get; set; }
        public bool HasBacktrackPath { get; set; }
        public bool Visited { get; set; }
        public bool VisitedBack { get; set; }

        public MazeCell(int x, int y)
        {
            this.X = x;
            this.Y = y;
            BuildDirections = new List<MazeDirection>() { MazeDirection.Up, MazeDirection.Right, MazeDirection.Down, MazeDirection.Left };
            ExploreDirections = new List<MazeDirection>();
            HasPath = false;
            HasBacktrackPath = false;
            Visited = false;
        }

        public override string ToString()
        {
            MazeDirection[] directions = new MazeDirection[5] { MazeDirection.None, MazeDirection.Up, MazeDirection.Right, MazeDirection.Down, MazeDirection.Left };
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format("X: {0}", this.X));
            sb.AppendLine(string.Format("Y: {0}", this.Y));
            sb.AppendLine(string.Format("CanContinueBuild: {0}", this.CanContinueBuild));
            sb.AppendLine(string.Format("Built: {0}", this.HasPath));
            sb.AppendLine(string.Format("BuildDirections: "));
            foreach (MazeDirection direction in directions)
            {
                if (this.BuildDirections.Contains(direction))
                {
                    sb.Append(string.Format(" {0} ", direction));
                }
            }
            sb.AppendLine(string.Format("ExploreDirections: "));
            foreach (MazeDirection direction in directions)
            {
                if (this.ExploreDirections.Contains(direction))
                {
                    sb.Append(string.Format(" {0} ", direction));
                }
            }
            return sb.ToString();
        }
    }
}
