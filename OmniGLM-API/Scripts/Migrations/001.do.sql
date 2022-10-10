-- As of right now, we don't have postgrator running these migrations. 
-- There's permission shit I don't feel like fucking with
-- so we're just running them manually and keeping them here for archival. 
-- TODO: add postgrator support 

CREATE TABLE IF NOT EXISTS series
(
    id uuid PRIMARY KEY DEFAULT gen_random_uuid(),
    series_title TEXT NOT NULL
);

CREATE TABLE IF NOT EXISTS genres
(
    id uuid PRIMARY KEY DEFAULT gen_random_uuid(),
    genre_name TEXT NOT NULL
);

CREATE TABLE IF NOT EXISTS consoles
(
    id uuid PRIMARY KEY DEFAULT gen_random_uuid(),
    console_name TEXT NOT NULL
);

CREATE TABLE IF NOT EXISTS games
(
    id uuid PRIMARY KEY DEFAULT gen_random_uuid(),
	title TEXT NOT NULL,
    series_id UUID,
    genre_id UUID NOT NULL,
    console_id UUID NOT NULL,
    release_date DATE NOT NULL,
    status TEXT NOT NULL,
    length INT NOT NULL,
    date_added DATE NOT NULL,
    date_completed DATE,
    blocked_by UUID,
    format TEXT NOT NULL,
    condition TEXT NOT NULL,
    notes TEXT,
    CONSTRAINT fk_series FOREIGN KEY(series_id) REFERENCES series(id),
    CONSTRAINT fk_genres FOREIGN KEY(genre_id) REFERENCES genres(id),
    CONSTRAINT fk_consoles FOREIGN KEY(console_id) REFERENCES consoles(id),
    CONSTRAINT fk_games FOREIGN KEY(blocked_by) REFERENCES games(id)
);

COMMIT;