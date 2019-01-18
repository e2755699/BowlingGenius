using System.Collections.Generic;
using System.Linq;

namespace BowlingGenius
{
    public class Game
    {
        private int _totalScore;
        private readonly RollingSections _rollingSections = new RollingSections();

        public void Roll(int i)
        {
            var rollingSection = _rollingSections.GetLatestSection();
            if (rollingSection == null || rollingSection.IsFull)
            {
                _rollingSections.CreateNewSection();
            }
            _rollingSections.Roll(i);
        }

        public int Score()
        {
            return _rollingSections.Score();
        }
    }

    internal class RollingSections
    {
        private readonly List<RollingSection> _rollingSections = new List<RollingSection>();

        public RollingSection GetLatestSection()
        {
            return LatestSection;
        }

        private RollingSection LatestSection => _rollingSections.LastOrDefault();

        public void CreateNewSection()
        {
            var rollingSection = new RollingSection();
            _rollingSections.Add(rollingSection);
            if (IsFinalSection)
            {
                rollingSection.IsFinalSection = true;
            }
        }

        private bool IsFinalSection => _rollingSections.Count == 10;

        public void Roll(int point)
        {
            if (IsFinalSection)
            {
                FinalSectionRoll(point);
            }
            else
            {
                NomarlRoll(point);
            }
        }

        private void NomarlRoll(int point)
        {
            LatestSection.Roll(point);
            foreach (var rollingSection in _rollingSections.Except(EnumerableOfLatest()))
            {
                rollingSection.UpdateBonusScore(point);
            }
        }

        private void FinalSectionRoll(int point)
        {
            LatestSection.RollEndSection(point);
        }

        private IEnumerable<RollingSection> EnumerableOfLatest()
        {
            yield return LatestSection;
        }

        public int Score()
        {
            return _rollingSections.Sum(x => x.Score());
        }
    }

    public class RollingSection
    {
        private int _score;
        public Bonus Bonus = new Bonus();
        private int _ball;
        public bool IsFull => !IsFinalSection && (_ball == 2 || Bonus.HasBonus);
        public bool IsFinalSection { get; set; }

        public void Roll(int point)
        {
            _score = _score + point;
            _ball++;
            if (_score == 10)
            {
                if (_ball == 2)
                {
                    Bonus.Spare();
                }
                else
                {
                    Bonus.Strike();
                }
            }
        }

        public int Score()
        {
            return IsEnd() ? _score : 0;
        }

        private bool IsEnd()
        {
            return (_ball >= 2 && !Bonus.HasBonus) || (Bonus.HasBonus && Bonus.Times == 0);
        }

        public void UpdateBonusScore(int point)
        {
            if (Bonus.Times > 0)
            {
                Bonus.Times--;
                _score = _score + point;
            }
        }

        public void RollEndSection(int point)
        {
            if ((_score == 10 && _ball <= 3) || _ball <= 2)
            {
                _score = _score + point;
            }
            _ball++;
        }
    }

    public class Bonus
    {
        public int Times;

        public void Spare()
        {
            HasBonus = true;
            Times = 1;
        }

        public bool HasBonus { get; set; }

        public void Strike()
        {
            HasBonus = true;
            Times = 2;
        }
    }
}