INSERT INTO
    series(series_title)

VALUES
    ('Pikmin'),
    ('Mana'),
    ('Assassin''s Creed'),
    ('Xeno'),
    ('Final Fantasy');


INSERT INTO
    genres(genre_name)

VALUES
    ('Visual Novel'),
    ('Real-time Strategy'),
    ('Simulation'),
    ('Roguelike'),
    ('Japanese RPG'),
    ('Action-Adventure'),
    ('Rail Shooter');


INSERT INTO
    consoles(console_name)

VALUES
    ('PC'),
    ('GameCube'),
    ('Xbox 360'),
    ('Playstation 4'),
    ()


INSERT INTO
    games(title, series_id, genre_id, console_id, release_date, status, length, date_added, date_completed, blocked_by, format, condition, notes)

VALUES
    ('HuniePop', null, 'c173fd53-0483-48c9-bab2-2c248942a868', 'console', '2015-1-19', 'PLAYING', 10, now(), null, null, 'DIGITAL', 'N/A', 'This game is gross'),
    ('Pikmin 2', '1488bc11-e295-419d-8d95-d6a94402e20d', '3f4e181a-eb55-4932-a8f0-e29ce90ac5eb'),
    ('Way of the Samurai 3', 'ade7c230-5457-4f2d-afcb-6ddc6d71750f', 'cd5edde4-8baf-4317-aaa5-708c220e93d5'),
    ('Dead Cells', null, '7b7c7f3a-6b4f-4195-b767-3e1608260579'),
    ('Secret of Mana', 'fc254e40-ebc0-4428-859b-58d77728f1be', 'c8902bc6-2029-464d-990b-29465fa77b65'),
    ('Assassin''s Creed', '6a4bcfb9-92fd-4976-a946-dfd5e8fb6b97', '9ad4f0f9-a4f6-479e-92d4-d85f7fa6475a'),
    ('Tin Star', null, '8e523eb5-9da9-4a22-8ae3-44a695a8fde1'),
    ('Rogue Galaxy', null, 'c8902bc6-2029-464d-990b-29465fa77b65'),
    ('Xenoblade Chronicles 3', '593cc71a-2544-4cc3-bf7d-a381d173015b', 'c8902bc6-2029-464d-990b-29465fa77b65'),
    ('Final Fantasy XV: Episode Duscae', '5ae79673-0585-44d7-bfde-bd3dcba67392', 'c8902bc6-2029-464d-990b-29465fa77b65'),