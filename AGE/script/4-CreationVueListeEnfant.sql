
CREATE VIEW V_ENfantListe
AS 
Select
M.Id,M.NumDossier,M.Nom,M.Prenom,M.DateNaissance,M.IGroupe,M.IdBus,L.IdListe,L.NomListe FROM Membre AS M 
join ListeMembre As LM on M.Id = LM.IdMembre
join Liste As L on Lm.IdListe = L.IdListe
