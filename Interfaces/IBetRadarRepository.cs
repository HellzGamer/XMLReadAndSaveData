using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewXmlWork.Model;

namespace NewXmlWork.Interfaces
{
    public interface IBetRadarRepository
    {
        void AddSport(Sport sport);
        void AddCategory(Category category);
        void AddTournament(Tournament tournament);
        void AddEvent(Event _event);
        void AddCompetitor(Competitor competitor);
        void AddBetType(BetType betType);
        void AddMarket(Markets market);
    }
}
