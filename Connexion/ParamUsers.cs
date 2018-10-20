using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace users_parameters
{


    public class User
    {
        public int id_user, param, secretaire, medecin, comptabilite, infirmier;
        public string nom;






        public User(int id_user, int param, int secretaire , int medecin, int comptabilite, int infirmier, string nom)
        {
            this.id_user = id_user;
            this.param = param; // Gstock
            this.secretaire = secretaire;
            this.medecin = medecin;
            this.comptabilite = comptabilite;
            this.infirmier= infirmier;
            this.nom = nom;
            
        }

        public string getFullName()
        {
            return nom;
        }
    }


   public class ParamUsers
    {
        Dictionary<int, User> users = null;
        int current_numUser = -1;

        public int Current_numUser
        {
            get { return current_numUser; }
            set { current_numUser = value; }
        }

        public ParamUsers(int current_numUser)
        {
            users = new Dictionary<int, User>();
            this.current_numUser = current_numUser;
        }

        public void addUser(User user)
        {
            users.Add(user.id_user, user);
        }

        public void addUser(int id_user, int param, int secretaire, int medecin, int comptabilite, int infirmier, string nom)
        {
            addUser(new User(id_user, param, secretaire, medecin, comptabilite, infirmier,nom));
        }

        public User getUser(int id_user)
        {
            return users[id_user];
        }

        public User getUser(string str_numUser)
        {
            return getUser(int.Parse(str_numUser));
        }

        public User getCurrentUser()
        {
            return getUser(this.current_numUser);
        }
    
}
}
