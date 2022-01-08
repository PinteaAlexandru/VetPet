CREATE TABLE [dbo].[Programari] (
    [ProgramareId] INT NOT NULL,
    [MedicId]      INT NULL,
    [ProgramId]    INT NULL,
    PRIMARY KEY CLUSTERED ([ProgramareId] ASC)
	CONSTRAINT fk_orders_med_id
	 FOREIGN KEY(MedicId)
	 REFERENCES Medici (MedicId)
	 ON DELETE CASCADE
	  ON UPDATE CASCADE,
	 CONSTRAINT jk_orders_pgm_id
	 FOREIGN KEY (ProgramId)
	 REFERENCES Program (ProgramId)
	 ON DELETE CASCADE
	  ON UPDATE CASCADE
    
);

