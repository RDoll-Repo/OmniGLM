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
    ('Super Nintendo'),
    ('Playstation 3'),
    ('Playstation 2'),
    ('Nintendo Switch');


INSERT INTO
    games(title, series_id, genre_id, console_id, release_date, status, length, date_added, date_completed, blocked_by, format, condition, notes)

VALUES
    ('HuniePop', null, 'c173fd53-0483-48c9-bab2-2c248942a868', '4092bd8a-cd95-436b-9f27-d6f83ea2dc15', '2015-1-19', 'PLAYING', 10, now(), null, null, 'DIGITAL', 'N/A', 'This game is gross'),
    ('Pikmin 2', '1488bc11-e295-419d-8d95-d6a94402e20d', '3f4e181a-eb55-4932-a8f0-e29ce90ac5eb', 'a5dce297-0540-4aab-816a-71d275cc765b', '2004-3-29', 'UNFINISHED', 20, now(), null, null, 'PHYSICAL', 'COMPLETEINBOX', null),
    ('Way of the Samurai 3', 'ade7c230-5457-4f2d-afcb-6ddc6d71750f', 'cd5edde4-8baf-4317-aaa5-708c220e93d5', '45d474fa-761a-4195-b51c-b4ce2a9b5a07', '2013-1-19', 'PLAYING', 15, now(), null, null, 'DIGITAL', 'N/A', null),
    ('Dead Cells', null, '7b7c7f3a-6b4f-4195-b767-3e1608260579', '4dab4f9d-219a-4bf1-b3ea-96ad2c07e7af', '2017-1-19', 'PLAYING', 10, now(), null, null, 'DIGITAL', 'N/A', null),
    ('Secret of Mana', 'fc254e40-ebc0-4428-859b-58d77728f1be', 'c8902bc6-2029-464d-990b-29465fa77b65', '54e2945e-a2a0-4c33-8887-25c955f850ee', '1992-1-19', 'PLAYING', 10, now(), null, null, 'DIGITAL', 'N/A', null),
    ('Assassin''s Creed', '6a4bcfb9-92fd-4976-a946-dfd5e8fb6b97', '9ad4f0f9-a4f6-479e-92d4-d85f7fa6475a', '33207824-a5fc-4a0b-b875-4446ab62e300', '2006-1-19', 'FINISHED', 10, now(), null, null, 'DIGITAL', 'N/A', null),
    ('Tin Star', null, '8e523eb5-9da9-4a22-8ae3-44a695a8fde1', '54e2945e-a2a0-4c33-8887-25c955f850ee', '1991-1-19', 'FINISHED', 10, now(), null, null, 'DIGITAL', 'N/A', null),
    ('Rogue Galaxy', null, 'c8902bc6-2029-464d-990b-29465fa77b65', 'ff656ca4-dec6-4be8-a2af-d9b654c2cb1c', '2003-1-19', 'PLAYING', 10, now(), null, null, 'DIGITAL', 'N/A', null),
    ('Xenoblade Chronicles 3', '593cc71a-2544-4cc3-bf7d-a381d173015b', 'c8902bc6-2029-464d-990b-29465fa77b65', '7891aeb5-22ed-4b15-8992-b67b7f802feb', '2022-1-19', 'UNFINISHED', 10, now(), null, null, 'DIGITAL', 'N/A', null),
    ('Final Fantasy XV: Episode Duscae', '5ae79673-0585-44d7-bfde-bd3dcba67392', 'c8902bc6-2029-464d-990b-29465fa77b65', '4dab4f9d-219a-4bf1-b3ea-96ad2c07e7af', '2014-1-19', 'UNIFINISHED', 10, now(), null, null, 'DIGITAL', 'N/A', null);