CREATE TABLE IF NOT EXISTS games
(
    id uuid PRIMARY KEY DEFAULT gen_random_uuid(),
	title TEXT NOT NULL,
    "status" TEXT NOT NULL,
    console TEXT NOT NULL,
    format TEXT NOT NULL,
    genre TEXT NOT NULL,
    length int NOT NULL,
    date_added TIMESTAMPTZ NOT NULL,
    date_completed TIMESTAMPTZ,
    notes TEXT 
);

COMMIT;