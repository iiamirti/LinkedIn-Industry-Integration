namespace YourNamespace.Dto;

public class LinkedinIndustryData
{
    public static class LinkedInIndustryData
    {
        public const string IndustriesJson = @"
[
  {
    ""id"": 2190,
    ""label"": ""Accommodation Services"",
    ""hierarchy"": ""Accommodation Services"",
    ""description"": ""This industry includes entities that provide short-term lodging in facilities, such as hotels, motels, and bed-and-breakfast inns. In addition to lodging, they may provide a range of other services for their guests.""
  },
  {
    ""id"": 34,
    ""label"": ""Food and Beverage Services"",
    ""hierarchy"": ""Accommodation Services > Food and Beverage Services"",
    ""description"": ""This industry includes entities that prepare meals, snacks, and beverages to customer order, for immediate on-premises and off-premises consumption.""
  },
  {
    ""id"": 2217,
    ""label"": ""Bars, Taverns, and Nightclubs"",
    ""hierarchy"": ""Accommodation Services > Food and Beverage Services > Bars, Taverns, and Nightclubs"",
    ""description"": ""This industry includes entities known as bars, taverns, nightclubs, or drinking places preparing and serving alcoholic beverages for immediate consumption.""
  },
  {
    ""id"": 2212,
    ""label"": ""Caterers"",
    ""hierarchy"": ""Accommodation Services > Food and Beverage Services > Caterers"",
    ""description"": ""This industry includes entities that provide single event-based food services and generally have equipment and vehicles to transport meals and snacks to events and/or prepare food at an off-premises site.""
  },
  {
    ""id"": 2214,
    ""label"": ""Mobile Food Services"",
    ""hierarchy"": ""Accommodation Services > Food and Beverage Services > Mobile Food Services"",
    ""description"": ""This industry includes entities that prepare and serve meals and snacks for immediate consumption from motorized vehicles or nonmotorized carts. The entity is the central location from which the caterer route is serviced, not each vehicle or cart. Included in this industry are entities that provide food services from vehicles, such as hot dog carts and ice cream trucks.""
  },
  {
    ""id"": 32,
    ""label"": ""Restaurants"",
    ""hierarchy"": ""Accommodation Services > Food and Beverage Services > Restaurants"",
    ""description"": ""This industry includes entities that provide food to patrons who are served while seated and pay after eating, or those who select items (e.g., at a counter, in a buffet line) and pay before eating. Entities that prepare and/or serve specialty snacks and/or nonalcoholic beverages for consumption on or near the premises are included.""
  },
  {
    ""id"": 31,
    ""label"": ""Hospitality"",
    ""hierarchy"": ""Accommodation Services > Hospitality"",
    ""description"": ""This industry includes entities that provide customers with lodging and/or prepared meals, snacks, and beverages for immediate consumption.""
  },
  {
    ""id"": 2197,
    ""label"": ""Bed-and-Breakfasts, Hostels, Homestays"",
    ""hierarchy"": ""Accommodation Services > Hospitality > Bed-and-Breakfasts, Hostels, Homestays"",
    ""description"": ""This industry includes entities that provide short-term lodging and food (except hotels, motels, and casino hotels).""
  },
  {
    ""id"": 2194,
    ""label"": ""Hotels and Motels"",
    ""hierarchy"": ""Accommodation Services > Hospitality > Hotels and Motels"",
    ""description"": ""This industry includes entities that provide short-term lodging specifically in facilities known as hotels, motor hotels, resort hotels, and motels.""
  },
  {
    ""id"": 1912,
    ""label"": ""Administrative and Support Services"",
    ""hierarchy"": ""Administrative and Support Services"",
    ""description"": ""This industry includes entities that perform routine support activities for the day-to-day operations of other organizations, including office administration, hiring and placing of personnel, document preparation and similar clerical services, solicitation, collection, security and surveillance services, cleaning, and waste disposal services.""
  },
  {
    ""id"": 1938,
    ""label"": ""Collection Agencies"",
    ""hierarchy"": ""Administrative and Support Services > Collection Agencies"",
    ""description"": ""This industry includes entities that collect payments for claims and remitting payments collected to their clients.""
  },
  {
    ""id"": 110,
    ""label"": ""Events Services"",
    ""hierarchy"": ""Administrative and Support Services > Events Services"",
    ""description"": ""This industry includes entities that organize, promote, and/or manage events, such as business and trade shows, conventions, conferences, and meetings, held in facilities they manage and operate or in facilities that are managed and operated by others.""
  },
  {
    ""id"": 122,
    ""label"": ""Facilities Services"",
    ""hierarchy"": ""Administrative and Support Services > Facilities Services"",
    ""description"": ""This industry includes entities that provide operating staff who perform a combination of services within a client's facilities (excluding computer and/or data processing facilities, which are in separate industries), such as janitorial, maintenance, trash disposal, guard and security, mail routing, reception, and laundry. Entities that provide private jail services or operate correctional facilities on a contract or fee basis are included.""
  },
  {
    ""id"": 1965,
    ""label"": ""Janitorial Services"",
    ""hierarchy"": ""Administrative and Support Services > Facilities Services > Janitorial Services"",
    ""description"": ""This industry includes entities that clean building interiors, interiors of transportation equipment (e.g., aircraft, rail cars, ships), and/or windows.""
  },
  {
    ""id"": 2934,
    ""label"": ""Landscaping Services"",
    ""hierarchy"": ""Administrative and Support Services > Facilities Services > Landscaping Services"",
    ""description"": ""This industry includes entities that 1. Provide landscape care and maintenance services and/or installing trees, shrubs, plants, lawns, or gardens 2. Provide these services along with the design of landscape plans and/or the installation of walkways, retaining walls, decks, fences, ponds, and similar structures.""
  },
  {
    ""id"": 101,
    ""label"": ""Fundraising"",
    ""hierarchy"": ""Administrative and Support Services > Fundraising"",
    ""description"": ""This industry includes entities that provide business support services, in particular fundraising organization services on a contract or fee basis.""
  },
  {
    ""id"": 1916,
    ""label"": ""Office Administration"",
    ""hierarchy"": ""Administrative and Support Services > Office Administration"",
    ""description"": ""This industry includes entities that provide a range of day-to-day office administrative services, such as financial planning; billing and recordkeeping; personnel; and physical distribution and logistics, for others on a contract or fee basis.""
  },
  {
    ""id"": 121,
    ""label"": ""Security and Investigations"",
    ""hierarchy"": ""Administrative and Support Services > Security and Investigations"",
    ""description"": ""This industry includes entities that: 1. Provide investigation, guard, and armored car services2. Sell security systems, such as burglar and fire alarms and locking devices, along with installation, repair, or monitoring services3. Provide remote monitoring of electronic security alarm systems.""
  },
  {
    ""id"": 1956,
    ""label"": ""Security Guards and Patrol Services"",
    ""hierarchy"": ""Administrative and Support Services > Security and Investigations > Security Guards and Patrol Services"",
    ""description"": ""This industry includes entities that provide staff for guard and patrol services, such as bodyguard, guard dog, and parking security services.""
  },
  {
    ""id"": 1958,
    ""label"": ""Security Systems Services"",
    ""hierarchy"": ""Administrative and Support Services > Security and Investigations > Security Systems Services"",
    ""description"": ""This industry includes entities that sell security systems hardware , such as burglar and fire alarms and locking devices, along with installation, repair, or remote monitoring of electronic security alarm systems.""
  },
  {
    ""id"": 104,
    ""label"": ""Staffing and Recruiting"",
    ""hierarchy"": ""Administrative and Support Services > Staffing and Recruiting"",
    ""description"": ""This industry includes entities that: 1. List employment vacancies and place or refer applicants for employment 2. Provide executive search, recruitment, and placement services 3. Supply workers to clients' businesses for limited periods of time; or 4.Provide day-to-day human resources and human resources management services to client businesses and households. Human resources outsourcing firms are included in this industry. This industry does not include entities that provide consulting on human resources policies and procedures.""
  },
  {
    ""id"": 1923,
    ""label"": ""Executive Search Services"",
    ""hierarchy"": ""Administrative and Support Services > Staffing and Recruiting > Executive Search Services"",
    ""description"": ""This industry includes entities that provide executive search, recruitment, and placement services for clients with specific executive and senior management position requirements, including developing a search strategy and position specification based on the culture and needs of the client; researching, identifying, screening, and interviewing candidates; verifying candidate qualifications; and assisting in final offer negotiations and assimilation of the selected candidate.""
  },
  {
    ""id"": 1925,
    ""label"": ""Temporary Help Services"",
    ""hierarchy"": ""Administrative and Support Services > Staffing and Recruiting > Temporary Help Services"",
    ""description"": ""This industry includes entities that supply workers to client's businesses for limited periods of time to supplement the working force of the client.""
  },
  {
    ""id"": 1931,
    ""label"": ""Telephone Call Centers"",
    ""hierarchy"": ""Administrative and Support Services > Telephone Call Centers"",
    ""description"": ""This industry includes entities that 1. Answer telephone calls and relay messages to clients or 2. Provide telemarketing services on a contract or fee basis for others, such as promoting client's products or services by telephone; taking orders for clients by telephone; and soliciting contributions or providing information for clients by telephone.""
  },
  {
    ""id"": 108,
    ""label"": ""Translation and Localization"",
    ""hierarchy"": ""Administrative and Support Services > Translation and Localization"",
    ""description"": ""This industry includes entities that translate written material and interpret speech from one language to another.""
  },
  {
    ""id"": 30,
    ""label"": ""Travel Arrangements"",
    ""hierarchy"": ""Administrative and Support Services > Travel Arrangements"",
    ""description"": ""This industry includes entities that provide travel agency services, arrange or assemble tours, or provide other travel arrangement and reservation services.""
  },
  {
    ""id"": 103,
    ""label"": ""Writing and Editing"",
    ""hierarchy"": ""Administrative and Support Services > Writing and Editing"",
    ""description"": ""This industry includes entities that create documents or resumes, edit or proofread documents, transcribe documents, and/or provide other writing and editing services.""
  },
  {
    ""id"": 48,
    ""label"": ""Construction"",
    ""hierarchy"": ""Construction"",
    ""description"": ""This industry includes entities that construct buildings or engineer projects (e.g., highways and utility systems) and perform specific activities (e.g., painting and plumbing).""
  },
  {
    ""id"": 406,
    ""label"": ""Building Construction"",
    ""hierarchy"": ""Construction > Building Construction"",
    ""description"": ""This industry includes entities that construct buildings, including temporary buildings and precut, panelized, and prefabricated buildings assembled on-site. New work, additions, alterations, or maintenance and repairs are also included.""
  },
  {
    ""id"": 413,
    ""label"": ""Nonresidential Building Construction"",
    ""hierarchy"": ""Construction > Building Construction > Nonresidential Building Construction"",
    ""description"": ""This industry includes entities that construct nonresidential buildings (including new work, additions, alterations, maintenance, and repairs). This includes the work of nonresidential general contractors, nonresidential for-sale builders, nonresidential design-build firms, and nonresidential project construction management firms.""
  },
  {
    ""id"": 408,
    ""label"": ""Residential Building Construction"",
    ""hierarchy"": ""Construction > Building Construction > Residential Building Construction"",
    ""description"": ""This industry includes entities that construct or remodel and renovate single-family and multifamily residential buildings. Included are residential housing general contractors (such as, new construction, remodeling, or renovating existing residential structures), for-sale builders and remodelers of residential structures, residential project construction management firms, and residential design-build firms.""
  },
  {
    ""id"": 51,
    ""label"": ""Civil Engineering"",
    ""hierarchy"": ""Construction > Civil Engineering"",
    ""description"": ""This industry includes entities that conduct engineering projects such as the construction of highways, dams, and utility systems.""
  },
  {
    ""id"": 431,
    ""label"": ""Highway, Street, and Bridge Construction"",
    ""hierarchy"": ""Construction > Civil Engineering > Highway, Street, and Bridge Construction"",
    ""description"": ""This industry includes entities that construct highways (including elevated), streets, roads, airport runways, public sidewalks, or bridges. The work performed may include new work, reconstruction, rehabilitation, and repairs.""
  },
  {
    ""id"": 428,
    ""label"": ""Subdivision of Land"",
    ""hierarchy"": ""Construction > Civil Engineering > Subdivision of Land"",
    ""description"": ""This industry includes entities that service land and subdivide property into lots for subsequent sale to builders. This may include excavation work for the installation of roads and utility lines. Entities that perform only the legal subdivision of land are not included.""
  },
  {
    ""id"": 419,
    ""label"": ""Utility System Construction"",
    ""hierarchy"": ""Construction > Civil Engineering > Utility System Construction"",
    ""description"": ""This industry includes entities that construct distribution lines and related buildings and structures for utilities (such as, water, sewer, petroleum, gas, power, and communication). All structures (including buildings) that are integral parts of utility systems (e.g., storage tanks, pumping stations, power plants, and refineries) are included.""
  },
  {
    ""id"": 435,
    ""label"": ""Specialty Trade Contractors"",
    ""hierarchy"": ""Construction > Specialty Trade Contractors"",
    ""description"": ""This industry includes entities that perform specific activities (e.g., pouring concrete, site preparation, plumbing, painting, and electrical work) involved in building construction or similar construction work, but are not responsible for the entire project. This includes new work, additions, alterations, maintenance, and repairs.""
  },
  {
    ""id"": 453,
    ""label"": ""Building Equipment Contractors"",
    ""hierarchy"": ""Construction > Specialty Trade Contractors > Building Equipment Contractors"",
    ""description"": ""This industry includes entities that install or service equipment that forms part of a building mechanical system (e.g., electricity, water, heating, and cooling). Contractors installing specialized building equipment, such as elevators, escalators, service station equipment, and central vacuum cleaning systems are also included.""
  },
  {
    ""id"": 460,
    ""label"": ""Building Finishing Contractors"",
    ""hierarchy"": ""Construction > Specialty Trade Contractors > Building Finishing Contractors"",
    ""description"": ""This industry includes entities that provide specialty trades needed to finish buildings. This includes new work, additions, alterations, maintenance, and repairs.""
  },
  {
    ""id"": 436,
    ""label"": ""Building Structure and Exterior Contractors"",
    ""hierarchy"": ""Construction > Specialty Trade Contractors > Building Structure and Exterior Contractors"",
    ""description"": ""This industry includes entities that provide specialty trades needed to complete the basic structure (such as, foundation, frame, and shell) of buildings. This includes new work, additions, alterations, maintenance, and repairs.""
  },
  {
    ""id"": 91,
    ""label"": ""Consumer Services"",
    ""hierarchy"": ""Consumer Services"",
    ""description"": ""This industry includes entities that repair cars, machinery, electronics, furniture, footwear, and leather goods, and those that provide personal services such as laundry, pet care, and household services.""
  },
  {
    ""id"": 90,
    ""label"": ""Civic and Social Organizations"",
    ""hierarchy"": ""Consumer Services > Civic and Social Organizations"",
    ""description"": ""This industry includes entities that organize religious activities; promote causes and beliefs for the public good; support charitable and other causes through grantmaking; advocate social and political causes; and promote and defend the interests of their members.""
  },
  {
    ""id"": 1909,
    ""label"": ""Industry Associations"",
    ""hierarchy"": ""Consumer Services > Civic and Social Organizations > Industry Associations"",
    ""description"": ""This industry includes entities that promote the business interests of their member companies and may conduct research on new products and services; develop market statistics; sponsor quality and certification standards; lobby public officials; or publish newsletters, books, or periodicals for distribution to their members.""
  },
  {
    ""id"": 107,
    ""label"": ""Political Organizations"",
    ""hierarchy"": ""Consumer Services > Civic and Social Organizations > Political Organizations"",
    ""description"": ""This industry includes entities that promote the interests of national or local parties or candidates. Political groups organized to raise funds for a political party or individual candidate are included.""
  },
  {
    ""id"": 1911,
    ""label"": ""Professional Organizations"",
    ""hierarchy"": ""Consumer Services > Civic and Social Organizations > Professional Organizations"",
    ""description"": ""This industry includes entities that promote the professional interests of their individual members and their profession as a whole; and may conduct research; develop statistics; sponsor quality and certification standards; lobby public officials; or publish newsletters, books, or periodicals for distribution to their members.""
  },
  {
    ""id"": 2318,
    ""label"": ""Household Services"",
    ""hierarchy"": ""Consumer Services > Household Services"",
    ""description"": ""This industry includes private households that employ workers on or off the premises in activities primarily concerned with the operation of the household, including cooks, maids, butlers, and outside workers, such as gardeners, caretakers, and other maintenance workers. This industry includes Private Service Professionals who primarily support the staff of individuals and families.""
  },
  {
    ""id"": 100,
    ""label"": ""Non-profit Organizations"",
    ""hierarchy"": ""Consumer Services > Non-profit Organizations"",
    ""description"": ""This industry includes entities that provide public benefit on a nonprofit basis, including those that organize and promote religious activities, support social and political causes, and provide programs and facilities for emergency relief, education, and donations of goods and services.""
  },
  {
    ""id"": 2258,
    ""label"": ""Personal and Laundry Services"",
    ""hierarchy"": ""Consumer Services > Personal and Laundry Services"",
    ""description"": ""This industry includes entities that provide personal and laundry services to individuals, households, and businesses, including personal care services; death care services; laundry and drycleaning services; and a wide range of other personal services, such as pet care (except veterinary) services, photofinishing services, temporary parking services, and dating services.""
  },
  {
    ""id"": 2272,
    ""label"": ""Laundry and Drycleaning Services"",
    ""hierarchy"": ""Consumer Services > Personal and Laundry Services > Laundry and Drycleaning Services"",
    ""description"": ""This industry includes entities that operate coin-operated or similar self-service laundries and drycleaners; that provide drycleaning and laundry services; and supply, on a rental or contract basis, laundered items (e.g., uniforms, gowns, shop towels, etc.).""
  },
  {
    ""id"": 2259,
    ""label"": ""Personal Care Services"",
    ""hierarchy"": ""Consumer Services > Personal and Laundry Services > Personal Care Services"",
    ""description"": ""This industry includes entities, such as barber and beauty shops, that provide appearance care services to individual consumers.""
  },
  {
    ""id"": 2282,
    ""label"": ""Pet Services"",
    ""hierarchy"": ""Consumer Services > Personal and Laundry Services > Pet Services"",
    ""description"": ""This industry includes entities that provide pet care services (except veterinary, which is in a separate industry), such as boarding, grooming, sitting, and training pets.""
  },
  {
    ""id"": 131,
    ""label"": ""Philanthropic Fundraising Services"",
    ""hierarchy"": ""Consumer Services > Philanthropic Fundraising Services"",
    ""description"": ""This industry includes grantmaking foundations, charitable trusts, and entities that raise funds for a wide range of social welfare activities, such as health, educational, scientific, and cultural activities.""
  },
  {
    ""id"": 89,
    ""label"": ""Religious Institutions"",
    ""hierarchy"": ""Consumer Services > Religious Institutions"",
    ""description"": ""This industry includes religious organizations, such as churches, religious temples, and monasteries, and/or entities that organize religion or promote religious activities.""
  },
  {
    ""id"": 2225,
    ""label"": ""Repair and Maintenance"",
    ""hierarchy"": ""Consumer Services > Repair and Maintenance"",
    ""description"": ""This industry includes entities that restore machinery, equipment, and other products to working order and provide general or routine maintenance (such as, servicing) on such products to ensure they work efficiently and to prevent breakdown and unnecessary repairs.""
  },
  {
    ""id"": 2247,
    ""label"": ""Commercial and Industrial Machinery Maintenance"",
    ""hierarchy"": ""Consumer Services > Repair and Maintenance > Commercial and Industrial Machinery Maintenance"",
    ""description"": ""This industry includes entities that repair and maintain commercial and industrial machinery and equipment, including either sharpening/installing commercial and industrial machinery blades and saws or provide welding (e.g., automotive, general) repair services; or repairing agricultural and other heavy and industrial machinery and equipment (e.g., forklifts and other material handling equipment, machine tools, commercial refrigeration equipment, construction equipment, and mining machinery).""
  },
  {
    ""id"": 2240,
    ""label"": ""Electronic and Precision Equipment Maintenance"",
    ""hierarchy"": ""Consumer Services > Repair and Maintenance > Electronic and Precision Equipment Maintenance"",
    ""description"": ""This industry includes entities that repair and maintain one or more of the following: 1. Consumer electronic equipment; 2. Computers; 3. Office machines; 4. Communication equipment; and 5. Other electronic and precision equipment and instruments, without retailing these products as new.""
  },
  {
    ""id"": 2255,
    ""label"": ""Footwear and Leather Goods Repair"",
    ""hierarchy"": ""Consumer Services > Repair and Maintenance > Footwear and Leather Goods Repair"",
    ""description"": ""This industry includes entities that repair footwear and/or other leather or leather-like goods without retailing new footwear and leather or leather-like goods, such as handbags and briefcases.""
  },
  {
    ""id"": 2253,
    ""label"": ""Reupholstery and Furniture Repair"",
    ""hierarchy"": ""Consumer Services > Repair and Maintenance > Reupholstery and Furniture Repair"",
    ""description"": ""This industry includes entities that offer one or more of the following services: 1. Reupholstering furniture; 2. Refinishing furniture; 3. Repairing furniture; and 4. Repairing and restoring furniture.""
  },
  {
    ""id"": 2226,
    ""label"": ""Vehicle Repair and Maintenance"",
    ""hierarchy"": ""Consumer Services > Repair and Maintenance > Vehicle Repair and Maintenance"",
    ""description"": ""This industry includes entities that provide repair and maintenance services for automotive vehicles, such as passenger cars, trucks, and vans, and all trailers.""
  },
  {
    ""id"": 1999,
    ""label"": ""Education"",
    ""hierarchy"": ""Education"",
    ""description"": ""This industry includes entities that provide instruction or training in a wide variety of subjects from specialized entities, such as schools, colleges, universities, and training centers.""
  },
  {
    ""id"": 132,
    ""label"": ""E-Learning Providers"",
    ""hierarchy"": ""Education > E-Learning Providers"",
    ""description"": ""This industry includes entities that offer instruction using electronic technologies, such as through web-based trainings, online learning platforms, and live or recorded lectures. Training may be tuition-based or open to the public, accredited or non-accredited.""
  },
  {
    ""id"": 68,
    ""label"": ""Higher Education"",
    ""hierarchy"": ""Education > Higher Education"",
    ""description"": ""This industry includes entities that furnish academic courses and grant degrees at baccalaureate or graduate levels, where the requirement for admission is at least a high school diploma or equivalent general academic training.""
  },
  {
    ""id"": 67,
    ""label"": ""Primary and Secondary Education"",
    ""hierarchy"": ""Education > Primary and Secondary Education"",
    ""description"": ""This industry includes entities that furnish academic courses and associated coursework to provide basic preparatory education, ordinarily kindergarten through 12th grade. School boards and school districts are included.""
  },
  {
    ""id"": 105,
    ""label"": ""Professional Training and Coaching"",
    ""hierarchy"": ""Education > Professional Training and Coaching"",
    ""description"": ""This industry includes entities that offer training courses in office skills, such as how to use software applications. Also included in this industry are entities that offer short-term courses for professional training. Computer repair training is not included in this industry.""
  },
  {
    ""id"": 2018,
    ""label"": ""Technical and Vocational Training"",
    ""hierarchy"": ""Education > Technical and Vocational Training"",
    ""description"": ""This industry includes entities that offer vocational and technical training in a variety of technical subjects and trades, including flight schools and apprenticeships but excluding office skills, which is in a separate industry.""
  },
  {
    ""id"": 2019,
    ""label"": ""Cosmetology and Barber Schools"",
    ""hierarchy"": ""Education > Technical and Vocational Training > Cosmetology and Barber Schools"",
    ""description"": ""This industry includes entities that offer training in barbering, hair styling, or the cosmetic arts, such as makeup or skin care.""
  },
  {
    ""id"": 2025,
    ""label"": ""Fine Arts Schools"",
    ""hierarchy"": ""Education > Technical and Vocational Training > Fine Arts Schools"",
    ""description"": ""This industry includes entities that offer instruction in the arts, including dance, art, drama, and music.""
  },
  {
    ""id"": 2020,
    ""label"": ""Flight Training"",
    ""hierarchy"": ""Education > Technical and Vocational Training > Flight Training"",
    ""description"": ""This industry includes entities that offer aviation and flight training.""
  },
  {
    ""id"": 2029,
    ""label"": ""Language Schools"",
    ""hierarchy"": ""Education > Technical and Vocational Training > Language Schools"",
    ""description"": ""This industry includes entities that offer foreign language instruction (including sign language).""
  },
  {
    ""id"": 2012,
    ""label"": ""Secretarial Schools"",
    ""hierarchy"": ""Education > Technical and Vocational Training > Secretarial Schools"",
    ""description"": ""This industry focuses on training for secretarial and administrative staff and includes entities that offer courses in secretarial and other basic office skills.""
  },
  {
    ""id"": 2027,
    ""label"": ""Sports and Recreation Instruction"",
    ""hierarchy"": ""Education > Technical and Vocational Training > Sports and Recreation Instruction"",
    ""description"": ""This industry includes entities, such as camps and schools, that offer instruction in athletic activities to groups of individuals.""
  },
  {
    ""id"": 28,
    ""label"": ""Entertainment Providers"",
    ""hierarchy"": ""Entertainment Providers"",
    ""description"": ""This industry includes entities that: 1. Produce, promote, or participate in live performances, events, or exhibits intended for the public; 2.Preserve and exhibit objects and sites of historical, cultural, or educational interest; and 3. Operate facilities or provide services that enable patrons to participate in recreational activities or pursue amusement, hobby, and leisure-time interests.""
  },
  {
    ""id"": 38,
    ""label"": ""Artists and Writers"",
    ""hierarchy"": ""Entertainment Providers > Artists and Writers"",
    ""description"": ""This industry includes independent (such as, freelance) individuals that perform in artistic productions, create artistic and cultural works, or provide technical expertise necessary for these productions.""
  },
  {
    ""id"": 37,
    ""label"": ""Museums, Historical Sites, and Zoos"",
    ""hierarchy"": ""Entertainment Providers > Museums, Historical Sites, and Zoos"",
    ""description"": ""This industry includes entities that preserve and exhibit objects, sites, and natural wonders of historical, cultural, and/or educational value.""
  },
  {
    ""id"": 2161,
    ""label"": ""Historical Sites"",
    ""hierarchy"": ""Entertainment Providers > Museums, Historical Sites, and Zoos > Historical Sites"",
    ""description"": ""This industry includes entities that preserve and exhibit sites, buildings, forts, or communities that describe events or persons of particular historical interest, such as archeological sites, battlefields, historical ships, and pioneer villages.""
  },
  {
    ""id"": 2159,
    ""label"": ""Museums"",
    ""hierarchy"": ""Entertainment Providers > Museums, Historical Sites, and Zoos > Museums"",
    ""description"": ""This industry includes entities that preserve and exhibit objects of historical, cultural, and/or educational value.""
  },
  {
    ""id"": 2163,
    ""label"": ""Zoos and Botanical Gardens"",
    ""hierarchy"": ""Entertainment Providers > Museums, Historical Sites, and Zoos > Zoos and Botanical Gardens"",
    ""description"": ""This industry includes entities that preserve and exhibit live plant and animal life displays.""
  },
  {
    ""id"": 115,
    ""label"": ""Musicians"",
    ""hierarchy"": ""Entertainment Providers > Musicians"",
    ""description"": ""This industry includes 1. Groups that produce live musical entertainment (except theatrical musical or opera productions, which are in separate industries) and 2. Independent (such as, freelance) artists that provide live musical entertainment. Musical groups and artists may perform in front of a live audience or in a studio; they may or may not operate their own facilities for staging shows.""
  },
  {
    ""id"": 2130,
    ""label"": ""Performing Arts and Spectator Sports"",
    ""hierarchy"": ""Entertainment Providers > Performing Arts and Spectator Sports"",
    ""description"": ""This industry includes entities that produce or organize and promote live presentations involving the performances of actors and actresses, singers, dancers, musical groups and artists, athletes, and other entertainers, including independent (such as, freelance) entertainers and the entities that manage their careers.""
  },
  {
    ""id"": 2139,
    ""label"": ""Circuses and Magic Shows"",
    ""hierarchy"": ""Entertainment Providers > Performing Arts and Spectator Sports > Circuses and Magic Shows"",
    ""description"": ""This industry includes companies or groups (except theater companies, dance companies, and musical groups and artists, which are in separate industries) producing live theatrical presentations.""
  },
  {
    ""id"": 2135,
    ""label"": ""Dance Companies"",
    ""hierarchy"": ""Entertainment Providers > Performing Arts and Spectator Sports > Dance Companies"",
    ""description"": ""This industry includes companies, groups, or theaters producing all types of live theatrical dance (e.g., ballet, contemporary dance, folk dance) presentations.""
  },
  {
    ""id"": 39,
    ""label"": ""Performing Arts"",
    ""hierarchy"": ""Entertainment Providers > Performing Arts and Spectator Sports > Performing Arts"",
    ""description"": ""This industry includes entities that produce live presentations featuring performances of actors and actresses, singers, dancers, musicians and musical groups, and other performing artists.""
  },
  {
    ""id"": 33,
    ""label"": ""Spectator Sports"",
    ""hierarchy"": ""Entertainment Providers > Performing Arts and Spectator Sports > Spectator Sports"",
    ""description"": ""This industry includes: 1. Sports teams, clubs, or independent athletes that participate in live sports events before a paying audience; 2. Entities that operate racetracks; 3. Owners of racing participants that enter them in spectator sports events; and 4. Entities such as trainers, that provide specialized services to support participants.""
  },
  {
    ""id"": 2143,
    ""label"": ""Racetracks"",
    ""hierarchy"": ""Entertainment Providers > Performing Arts and Spectator Sports > Spectator Sports > Racetracks"",
    ""description"": ""This industry includes entities that operate racetracks and may also present and/or promote the events, such as auto, dog, and horse races, held in these facilities.""
  },
  {
    ""id"": 2142,
    ""label"": ""Sports Teams and Clubs"",
    ""hierarchy"": ""Entertainment Providers > Performing Arts and Spectator Sports > Spectator Sports > Sports Teams and Clubs"",
    ""description"": ""This industry includes professional or semiprofessional sports teams or clubs participating in live sporting events, such as baseball, basketball, football, hockey, soccer, and jai alai games, before a paying audience.""
  },
  {
    ""id"": 2133,
    ""label"": ""Theater Companies"",
    ""hierarchy"": ""Entertainment Providers > Performing Arts and Spectator Sports > Theater Companies"",
    ""description"": ""This industry includes companies, groups, or theaters that offer the following live theatrical presentations: musicals; operas; plays; and comedy, improvisational, mime, and puppet shows and entities, commonly known as dinner theaters, that produce live theatrical productions along with food and beverages for consumption on the premises.""
  },
  {
    ""id"": 40,
    ""label"": ""Recreational Facilities"",
    ""hierarchy"": ""Entertainment Providers > Recreational Facilities"",
    ""description"": ""This industry includes entities that 1. Operate facilities where patrons can engage in sports, recreation, amusement, or gambling activities and/or 2. Provide other amusement and recreation, such as amusement devices in places of business operated by others; operation of sports teams, clubs, or leagues that play games for recreational purposes; and tours that do not use transportation equipment.""
  },
  {
    ""id"": 2167,
    ""label"": ""Amusement Parks and Arcades"",
    ""hierarchy"": ""Entertainment Providers > Recreational Facilities > Amusement Parks and Arcades"",
    ""description"": ""This industry includes entities that operate amusement parks and amusement arcades and parlors.""
  },
  {
    ""id"": 29,
    ""label"": ""Gambling Facilities and Casinos"",
    ""hierarchy"": ""Entertainment Providers > Recreational Facilities > Gambling Facilities and Casinos"",
    ""description"": ""This industry includes entities that operate gambling facilities, such as casinos, bingo halls, and video gaming terminals, or that provision gambling services, such as lotteries and off-track betting.""
  },
  {
    ""id"": 2179,
    ""label"": ""Golf Courses and Country Clubs"",
    ""hierarchy"": ""Entertainment Providers > Recreational Facilities > Golf Courses and Country Clubs"",
    ""description"": ""This industry includes entities that 1. Operate golf courses (except miniature) and 2. Operate golf courses along with dining facilities and other recreational facilities that are known as country clubs.""
  },
  {
    ""id"": 2181,
    ""label"": ""Skiing Facilities"",
    ""hierarchy"": ""Entertainment Providers > Recreational Facilities > Skiing Facilities"",
    ""description"": ""This industry includes entities that operate downhill, cross country/region, or related skiing areas and/or operate related equipment, such as ski lifts and tows.""
  },
  {
    ""id"": 124,
    ""label"": ""Wellness and Fitness Services"",
    ""hierarchy"": ""Entertainment Providers > Recreational Facilities > Wellness and Fitness Services"",
    ""description"": ""This industry includes entities that: 1. Operate fitness and recreational facilities for sports, such as swimming, skating, or racquet sports; and/or 2. Provide non-medical services to assist clients in attaining or maintaining a desired weight or healthfulness, such as individual or group counseling and menu and exercise planning.""
  },
  {
    ""id"": 201,
    ""label"": ""Farming, Ranching, Forestry"",
    ""hierarchy"": ""Farming, Ranching, Forestry"",
    ""description"": ""This industry includes entities that grow crops, raise animals, harvest timber, and harvest fish and other animals from a farm, ranch, or their natural habitats.""
  },
  {
    ""id"": 63,
    ""label"": ""Farming"",
    ""hierarchy"": ""Farming, Ranching, Forestry > Farming"",
    ""description"": ""This industry includes entities that grow crops mainly for food and fiber, such as farms, orchards, groves, greenhouses, and nurseries.""
  },
  {
    ""id"": 150,
    ""label"": ""Horticulture"",
    ""hierarchy"": ""Farming, Ranching, Forestry > Farming > Horticulture"",
    ""description"": ""This industry includes entities that cultivate garden plants, such as fruits, vegetables, flowers, and ornamentals.""
  },
  {
    ""id"": 298,
    ""label"": ""Forestry and Logging"",
    ""hierarchy"": ""Farming, Ranching, Forestry > Forestry and Logging"",
    ""description"": ""This industry includes entities that grow and harvest timber on a long production cycle (such as, of 10 years or more).""
  },
  {
    ""id"": 256,
    ""label"": ""Ranching and Fisheries"",
    ""hierarchy"": ""Farming, Ranching, Forestry > Ranching and Fisheries"",
    ""description"": ""This industry includes entities that raise or fatten animals and/or raise aquatic plants and aquatic animals in controlled or selected aquatic environments. This includes ranches, farms, and feedlots that keep animals for the products they produce or for eventual sale.""
  },
  {
    ""id"": 66,
    ""label"": ""Fisheries"",
    ""hierarchy"": ""Farming, Ranching, Forestry > Ranching and Fisheries > Fisheries"",
    ""description"": ""This industry includes entities that commercially catch finfish, shellfish, or miscellaneous marine products from a natural habitat, such as bluefish, eels, salmon, tuna, clams, crabs, lobsters, mussels, oysters, shrimp, frogs, sea urchins, and turtles.""
  },
  {
    ""id"": 64,
    ""label"": ""Ranching"",
    ""hierarchy"": ""Farming, Ranching, Forestry > Ranching and Fisheries > Ranching"",
    ""description"": ""This industry includes entities that raise cattle, milk dairy cattle, or feed cattle for fattening.""
  },
  {
    ""id"": 43,
    ""label"": ""Financial Services"",
    ""hierarchy"": ""Financial Services"",
    ""description"": ""This industry includes entities that make financial transactions (creation, liquidation, or change in ownership of financial assets) and/or that facilitate financial transactions.""
  },
  {
    ""id"": 129,
    ""label"": ""Capital Markets"",
    ""hierarchy"": ""Financial Services > Capital Markets"",
    ""description"": ""This industry includes entities that: 1. Underwrite securities issues and/or make markets for securities and commodities; 2. Act as brokers between buyers and sellers of securities and commodities; 3. Provide securities and commodity exchange services; and 4. Manage portfolios of assets, provide investment advice, and provide and trust, fiduciary, and custody services.""
  },
  {
    ""id"": 1720,
    ""label"": ""Investment Advice"",
    ""hierarchy"": ""Financial Services > Capital Markets > Investment Advice"",
    ""description"": ""This industry includes entities that provide customized investment advice to clients on a fee basis, but do not have the authority to execute trades.""
  },
  {
    ""id"": 45,
    ""label"": ""Investment Banking"",
    ""hierarchy"": ""Financial Services > Capital Markets > Investment Banking"",
    ""description"": ""This industry includes entities that underwrite, originate, and/or maintain markets for issues of securities, and entities that act as principals in buying or selling securities on a spread basis, such as securities dealers or stock option dealers.""
  },
  {
    ""id"": 46,
    ""label"": ""Investment Management"",
    ""hierarchy"": ""Financial Services > Capital Markets > Investment Management"",
    ""description"": ""This industry includes entities that act as principals or brokers in buying or selling financial contracts (except investment bankers and securities and commodity contracts dealers and brokerages, which are in separate industries). Also included are investment services (except securities and commodity exchanges, which are in separate industries) such as portfolio management, investment advice, and trust, fiduciary, and custody services.""
  },
  {
    ""id"": 1713,
    ""label"": ""Securities and Commodity Exchanges"",
    ""hierarchy"": ""Financial Services > Capital Markets > Securities and Commodity Exchanges"",
    ""description"": ""This industry includes entities that furnish physical or electronic marketplaces to facilitate the buying and selling of stocks, stock options, bonds, or commodity contracts.""
  },
  {
    ""id"": 106,
    ""label"": ""Venture Capital and Private Equity Principals"",
    ""hierarchy"": ""Financial Services > Capital Markets > Venture Capital and Private Equity Principals"",
    ""description"": ""This industry includes entities that act as principals (except investment bankers, securities dealers, and commodity contracts dealers, which are in separate industries) in buying or selling financial contracts generally on a spread basis.""
  },
  {
    ""id"": 1673,
    ""label"": ""Credit Intermediation"",
    ""hierarchy"": ""Financial Services > Credit Intermediation"",
    ""description"": ""This industry includes entities that primarily lend funds raised from depositors or from credit market borrowing; or facilitate the lending of funds or issuance of credit by engaging in such activities as mortgage and loan brokerage, clearinghouse and reserve services, and check cashing services.""
  },
  {
    ""id"": 41,
    ""label"": ""Banking"",
    ""hierarchy"": ""Financial Services > Credit Intermediation > Banking"",
    ""description"": ""This industry includes entities that accept demand and other deposits and make commercial, industrial, and consumer loans. Commercial banks and branches of foreign banks are included.""
  },
  {
    ""id"": 141,
    ""label"": ""International Trade and Development"",
    ""hierarchy"": ""Financial Services > Credit Intermediation > International Trade and Development"",
    ""description"": ""This industry includes entities that provide working capital funds to exporters; lend funds to foreign buyers of goods; or lend funds to domestic buyers of imported goods.""
  },
  {
    ""id"": 1696,
    ""label"": ""Loan Brokers"",
    ""hierarchy"": ""Financial Services > Credit Intermediation > Loan Brokers"",
    ""description"": ""This industry includes entities that primarily arrange loans by bringing borrowers and lenders together on a commission or fee basis.""
  },
  {
    ""id"": 1678,
    ""label"": ""Savings Institutions"",
    ""hierarchy"": ""Financial Services > Credit Intermediation > Savings Institutions"",
    ""description"": ""This industry includes entities that primarily accept time deposits, make mortgage and real estate loans, and invest in high-grade securities, including savings and loan associations and savings banks.""
  },
  {
    ""id"": 1742,
    ""label"": ""Funds and Trusts"",
    ""hierarchy"": ""Financial Services > Funds and Trusts"",
    ""description"": ""This industry includes legal entities (such as, funds, plans, and/or programs) organized to pool securities or other assets on behalf of shareholders or beneficiaries of employee benefit or other trust funds to earn interest, dividends, and other investment income.""
  },
  {
    ""id"": 1743,
    ""label"": ""Insurance and Employee Benefit Funds"",
    ""hierarchy"": ""Financial Services > Funds and Trusts > Insurance and Employee Benefit Funds"",
    ""description"": ""This industry includes legal entities (such as, funds, plans, and/or programs) organized to provide insurance and employee benefits exclusively for the sponsor, firm, or its employees or members.""
  },
  {
    ""id"": 1745,
    ""label"": ""Pension Funds"",
    ""hierarchy"": ""Financial Services > Funds and Trusts > Pension Funds"",
    ""description"": ""This industry includes legal entities (such as, funds, plans, and/or programs) organized to provide retirement income benefits exclusively for the sponsor's employees or members.""
  },
  {
    ""id"": 1750,
    ""label"": ""Trusts and Estates"",
    ""hierarchy"": ""Financial Services > Funds and Trusts > Trusts and Estates"",
    ""description"": ""This industry includes legal entities (such as, investment pools and/or funds) organized to pool securities or other assets (except insurance and employee benefit funds, which are in separate industries) on behalf of shareholders, unitholders, or beneficiaries.""
  },
  {
    ""id"": 42,
    ""label"": ""Insurance"",
    ""hierarchy"": ""Financial Services > Insurance"",
    ""description"": ""This industry includes entities that underwrite annuities and insurance policies or sell insurance policies and provide other insurance and employee-benefit-related services.""
  },
  {
    ""id"": 1738,
    ""label"": ""Claims Adjusting, Actuarial Services"",
    ""hierarchy"": ""Financial Services > Insurance > Claims Adjusting, Actuarial Services"",
    ""description"": ""This industry includes entities that primarily provide services related to insurance (except insurance agencies and brokerages).""
  },
  {
    ""id"": 1737,
    ""label"": ""Insurance Agencies and Brokerages"",
    ""hierarchy"": ""Financial Services > Insurance > Insurance Agencies and Brokerages"",
    ""description"": ""This industry includes entities that primarily act as agents (such as, brokers) in selling annuities and insurance policies.""
  },
  {
    ""id"": 1725,
    ""label"": ""Insurance Carriers"",
    ""hierarchy"": ""Financial Services > Insurance > Insurance Carriers"",
    ""description"": ""This industry includes entities that primarily provide underwriting (assuming the risk, assigning premiums, and so forth) annuities and insurance policies and investing premiums to build up a portfolio of financial assets to be used against future claims.""
  },
  {
    ""id"": 75,
    ""label"": ""Government Administration"",
    ""hierarchy"": ""Government Administration"",
    ""description"": ""This industry includes entities of federal, state, and local government agencies that administer, oversee, and manage public programs; organize and finance public goods and services; and have executive, legislative, or judicial authority over other institutions within a given area. These agencies set policy, create laws, adjudicate civil and criminal legal cases, and provide for public safety and national defense.""
  },
  {
    ""id"": 73,
    ""label"": ""Administration of Justice"",
    ""hierarchy"": ""Government Administration > Administration of Justice"",
    ""description"": ""This industry includes government entities that administer justice, including courts, correctional institutions, and other offices.""
  },
  {
    ""id"": 3068,
    ""label"": ""Correctional Institutions"",
    ""hierarchy"": ""Government Administration > Administration of Justice > Correctional Institutions"",
    ""description"": ""This industry includes government entities that manage and operate correctional institutions designed for the confinement, correction, and rehabilitation of adult and/or juvenile offenders sentenced by a court.""
  },
  {
    ""id"": 3065,
    ""label"": ""Courts of Law"",
    ""hierarchy"": ""Government Administration > Administration of Justice > Courts of Law"",
    ""description"": ""This industry includes civilian courts of law (except American Indian and Alaska Native tribal courts, which are in a separate industry).""
  },
  {
    ""id"": 3070,
    ""label"": ""Fire Protection"",
    ""hierarchy"": ""Government Administration > Administration of Justice > Fire Protection"",
    ""description"": ""This industry includes government entities that offer firefighting and other related fire protection activities.""
  },
  {
    ""id"": 77,
    ""label"": ""Law Enforcement"",
    ""hierarchy"": ""Government Administration > Administration of Justice > Law Enforcement"",
    ""description"": ""This industry includes government entities that enforce criminal and civil law, provide police activity, traffic safety, and other activities related to the enforcement of the law and preservation of order. Combined police and fire departments are included.""
  },
  {
    ""id"": 78,
    ""label"": ""Public Safety"",
    ""hierarchy"": ""Government Administration > Administration of Justice > Public Safety"",
    ""description"": ""This industry includes government entities that provide public order and safety (except courts, police protection, legal counsel and prosecution, correctional institutions, parole offices, probation offices, pardon boards, and fire protection). Government administration of public order, safety programs, and collection of statistics on public safety are included.""
  },
  {
    ""id"": 2375,
    ""label"": ""Economic Programs"",
    ""hierarchy"": ""Government Administration > Economic Programs"",
    ""description"": ""This industry includes government entities that administer economic programs.""
  },
  {
    ""id"": 3085,
    ""label"": ""Transportation Programs"",
    ""hierarchy"": ""Government Administration > Economic Programs > Transportation Programs"",
    ""description"": ""This industry includes government entities that focus on the administration, regulation, licensing, planning, inspection, and investigation of transportation services and facilities, including motor vehicle and operator licensing, the Coast Guard (except the Coast Guard Academy, which is in a separate industry), and parking authorities.""
  },
  {
    ""id"": 3086,
    ""label"": ""Utilities Administration"",
    ""hierarchy"": ""Government Administration > Economic Programs > Utilities Administration"",
    ""description"": ""This industry includes government entities that focus on administration, regulation, licensing, and inspection of utilities, such as communications, electric power (including fossil, nuclear, solar, water, and wind), gas and water supply, and sewerage.""
  },
  {
    ""id"": 388,
    ""label"": ""Environmental Quality Programs"",
    ""hierarchy"": ""Government Administration > Environmental Quality Programs"",
    ""description"": ""This industry includes government entities that administer environmental quality programs.""
  },
  {
    ""id"": 2366,
    ""label"": ""Air, Water, and Waste Program Management"",
    ""hierarchy"": ""Government Administration > Environmental Quality Programs > Air, Water, and Waste Program Management"",
    ""description"": ""This industry includes government entities that focus on administration, regulation, or enforcement of programs related to one or more of the following: 1. Air and water resources; 2. Solid waste management; 3. Water and air pollution control and prevention; 4. Flood control; 5. Drainage development and water resource consumption; 6. Toxic waste removal and cleanup; and/or coordination of these activities at intergovernmental levels.""
  },
  {
    ""id"": 2368,
    ""label"": ""Conservation Programs"",
    ""hierarchy"": ""Government Administration > Environmental Quality Programs > Conservation Programs"",
    ""description"": ""This industry includes government entities that focus on the administration, regulation, supervision, and control of land use, including recreational areas; conservation and preservation of natural resources; erosion control; geological survey program administration; weather forecasting program administration; and the administration and protection of publicly and privately owned forest lands, including game, fish, and wildlife populations, including wildlife management areas and field stations.""
  },
  {
    ""id"": 2353,
    ""label"": ""Health and Human Services"",
    ""hierarchy"": ""Government Administration > Health and Human Services"",
    ""description"": ""This industry includes government entities that administer human resource programs.""
  },
  {
    ""id"": 69,
    ""label"": ""Education Administration Programs"",
    ""hierarchy"": ""Government Administration > Health and Human Services > Education Administration Programs"",
    ""description"": ""This industry includes government entities that coordinate, plan, supervise, and administrate funds, policies, activities, statistical reports, data collection, and centralized programs for educational administration. Government scholarship programs are included.""
  },
  {
    ""id"": 2360,
    ""label"": ""Public Assistance Programs"",
    ""hierarchy"": ""Government Administration > Health and Human Services > Public Assistance Programs"",
    ""description"": ""This industry includes government entities that plan, administer, and coordinate programs for public assistance, social work, and welfare activities, including Social Security, disability insurance, Medicare, unemployment insurance, and workers' compensation programs.""
  },
  {
    ""id"": 2358,
    ""label"": ""Public Health"",
    ""hierarchy"": ""Government Administration > Health and Human Services > Public Health"",
    ""description"": ""This industry includes government entities that plan, administer, and coordinate public health programs and services, including environmental health activities, mental health, categorical health programs, health statistics, and immunization services.""
  },
  {
    ""id"": 2369,
    ""label"": ""Housing and Community Development"",
    ""hierarchy"": ""Government Administration > Housing and Community Development"",
    ""description"": ""This industry includes government entities that administer programs for housing, urban planning, and community development.""
  },
  {
    ""id"": 2374,
    ""label"": ""Community Development and Urban Planning"",
    ""hierarchy"": ""Government Administration > Housing and Community Development > Community Development and Urban Planning"",
    ""description"": ""This industry includes government entities that focus on the administration and planning of the development of urban and rural areas, including government zoning boards and commissions.""
  },
  {
    ""id"": 3081,
    ""label"": ""Housing Programs"",
    ""hierarchy"": ""Government Administration > Housing and Community Development > Housing Programs"",
    ""description"": ""This industry includes government entities that plan and administer housing programs.""
  },
  {
    ""id"": 2391,
    ""label"": ""Military and International Affairs"",
    ""hierarchy"": ""Government Administration > Military and International Affairs"",
    ""description"": ""This industry includes government entities that administer programs of national security and international affairs.""
  },
  {
    ""id"": 71,
    ""label"": ""Armed Forces"",
    ""hierarchy"": ""Government Administration > Military and International Affairs > Armed Forces"",
    ""description"": ""This industry includes government entities engaged in national security and related activities.""
  },
  {
    ""id"": 74,
    ""label"": ""International Affairs"",
    ""hierarchy"": ""Government Administration > Military and International Affairs > International Affairs"",
    ""description"": ""This industry includes entities of local and foreign governments that focus on international affairs and programs relating to other nations and peoples.""
  },
  {
    ""id"": 79,
    ""label"": ""Public Policy Offices"",
    ""hierarchy"": ""Government Administration > Public Policy Offices"",
    ""description"": ""This industry includes offices of government executives, legislative bodies, public finance, and general government support.""
  },
  {
    ""id"": 76,
    ""label"": ""Executive Offices"",
    ""hierarchy"": ""Government Administration > Public Policy Offices > Executive Offices"",
    ""description"": ""This industry includes government entities that serve as offices of chief executives and their advisory committees and commissions.""
  },
  {
    ""id"": 72,
    ""label"": ""Legislative Offices"",
    ""hierarchy"": ""Government Administration > Public Policy Offices > Legislative Offices"",
    ""description"": ""This industry includes government entities that serve as legislative bodies and their advisory committees and commissions.""
  },
  {
    ""id"": 3089,
    ""label"": ""Space Research and Technology"",
    ""hierarchy"": ""Government Administration > Space Research and Technology"",
    ""description"": ""This industry includes government entities that administer and operate space flights, space research, space exploration, and space flight centers.""
  },
  {
    ""id"": 1905,
    ""label"": ""Holding Companies"",
    ""hierarchy"": ""Holding Companies"",
    ""description"": ""This industry includes entities that hold equity interests in companies and enterprises for the purpose of owning a controlling interest or influencing management decisions. Entities in this industry don't have any of their own operations, but rather only have investments in other firms. Parent companies that have their own independent operations and also have subsidiaries are not included in this industry.""
  },
  {
    ""id"": 14,
    ""label"": ""Hospitals and Health Care"",
    ""hierarchy"": ""Hospitals and Health Care"",
    ""description"": ""This industry includes entities that provide health care and health-related social assistance for individuals. It includes entities that provide medical care exclusively, health care and social assistance, and only social assistance. These entities deliver services by trained professional health practitioners or social workers.""
  },
  {
    ""id"": 2115,
    ""label"": ""Community Services"",
    ""hierarchy"": ""Hospitals and Health Care > Community Services"",
    ""description"": ""This industry includes entities offer short-term emergency shelter, temporary residential shelter, transitional housing, volunteer construction or repair of low-cost housing; or food, shelter, clothing, medical relief, resettlement, and counseling to the needy, or to victims of domestic or international disasters or conflicts.""
  },
  {
    ""id"": 2112,
    ""label"": ""Services for the Elderly and Disabled"",
    ""hierarchy"": ""Hospitals and Health Care > Community Services > Services for the Elderly and Disabled"",
    ""description"": ""This industry includes entities that provide services in support of the elderly and disabled.""
  },
  {
    ""id"": 2081,
    ""label"": ""Hospitals"",
    ""hierarchy"": ""Hospitals and Health Care > Hospitals"",
    ""description"": ""This industry includes entities that provide varied medical, diagnostic, and treatment services that include physician, nursing, and other health services to inpatients.""
  },
  {
    ""id"": 88,
    ""label"": ""Individual and Family Services"",
    ""hierarchy"": ""Hospitals and Health Care > Individual and Family Services"",
    ""description"": ""This industry includes entities that provide nonresidential social assistance to children and youth, the elderly, persons with disabilities, and all other individuals and families.""
  },
  {
    ""id"": 2128,
    ""label"": ""Child Day Care Services"",
    ""hierarchy"": ""Hospitals and Health Care > Individual and Family Services > Child Day Care Services"",
    ""description"": ""This industry includes entities that provide day care of infants or children who are not in school and may also offer pre-kindergarten and/or kindergarten educational programs.""
  },
  {
    ""id"": 2122,
    ""label"": ""Emergency and Relief Services"",
    ""hierarchy"": ""Hospitals and Health Care > Individual and Family Services > Emergency and Relief Services"",
    ""description"": ""This industry includes entities that provide food, shelter, clothing, medical relief, resettlement, and counseling to victims of domestic or international disasters or conflicts (e.g., wars).""
  },
  {
    ""id"": 2125,
    ""label"": ""Vocational Rehabilitation Services"",
    ""hierarchy"": ""Hospitals and Health Care > Individual and Family Services > Vocational Rehabilitation Services"",
    ""description"": ""This industry includes entities that provide vocational rehabilitation or habilitation services, such as job counseling, job training, and work experience, to unemployed and underemployed persons, persons with disabilities, and persons who have a job market disadvantage because of lack of education, job skill, or experience and/or training and employment to persons with disabilities.""
  },
  {
    ""id"": 13,
    ""label"": ""Medical Practices"",
    ""hierarchy"": ""Hospitals and Health Care > Medical Practices"",
    ""description"": ""This industry includes individual medical practices that provide health care services directly or indirectly to ambulatory patients. This industry does not include hospitals, which are in a separate industry.""
  },
  {
    ""id"": 125,
    ""label"": ""Alternative Medicine"",
    ""hierarchy"": ""Hospitals and Health Care > Medical Practices > Alternative Medicine"",
    ""description"": ""This industry includes independent health practitioners including acupuncturists , hypnotherapists, homeopaths, and naturopaths. These practitioners operate private or group practices in their own offices or in the facilities of others (e.g., hospitals).""
  },
  {
    ""id"": 2077,
    ""label"": ""Ambulance Services"",
    ""hierarchy"": ""Hospitals and Health Care > Medical Practices > Ambulance Services"",
    ""description"": ""This industry includes entities that provide transportation of patients by ground or air, along with medical care.""
  },
  {
    ""id"": 2048,
    ""label"": ""Chiropractors"",
    ""hierarchy"": ""Hospitals and Health Care > Medical Practices > Chiropractors"",
    ""description"": ""This industry includes health practitioners having the degree of D.C. (Doctor of Chiropractic) practicing chiropractic therapy.""
  },
  {
    ""id"": 2045,
    ""label"": ""Dentists"",
    ""hierarchy"": ""Hospitals and Health Care > Medical Practices > Dentists"",
    ""description"": ""This industry includes health practitioners having the degree of D.M.D. (Doctor of Dental Medicine), D.D.S. (Doctor of Dental Surgery), or D.D.Sc. (Doctor of Dental Science) practicing general or specialized dentistry or dental surgery.""
  },
  {
    ""id"": 2060,
    ""label"": ""Family Planning Centers"",
    ""hierarchy"": ""Hospitals and Health Care > Medical Practices > Family Planning Centers"",
    ""description"": ""This industry includes entities with medical staff that provide a range of family planning services on an outpatient basis, such as contraceptive services, genetic and prenatal counseling, voluntary sterilization, and therapeutic and medically induced termination of pregnancy.""
  },
  {
    ""id"": 2074,
    ""label"": ""Home Health Care Services"",
    ""hierarchy"": ""Hospitals and Health Care > Medical Practices > Home Health Care Services"",
    ""description"": ""This industry includes entities that provide skilled nursing services in the home, along with a range of the following: personal care services; homemaker and companion services; physical therapy; medical social services; medication; support for medical equipment and supplies; counseling; 24-hour home care; occupation and vocational therapy; dietary and nutritional services; speech therapy; audiology; and high-tech care, such as intravenous therapy.""
  },
  {
    ""id"": 2069,
    ""label"": ""Medical and Diagnostic Laboratories"",
    ""hierarchy"": ""Hospitals and Health Care > Medical Practices > Medical and Diagnostic Laboratories"",
    ""description"": ""This industry includes medical and diagnostic laboratories that provide analytic or diagnostic services, including body fluid analysis and diagnostic imaging, generally to the medical profession or to the patient on referral from a health practitioner.""
  },
  {
    ""id"": 139,
    ""label"": ""Mental Health Care"",
    ""hierarchy"": ""Hospitals and Health Care > Medical Practices > Mental Health Care"",
    ""description"": ""This industry includes independent mental health practitioners (except physicians, which are in a separate industry) that diagnose and treat mental, emotional, and behavioral disorders and/or individual or group social dysfunction brought about by mental illness, alcohol and substance abuse, physical and emotional trauma, or stress. They operate private or group practices in their own offices or in the facilities of others (e.g., hospitals).""
  },
  {
    ""id"": 2050,
    ""label"": ""Optometrists"",
    ""hierarchy"": ""Hospitals and Health Care > Medical Practices > Optometrists"",
    ""description"": ""This industry includes health practitioners having the degree of O.D. (Doctor of Optometry) practicing optometry.""
  },
  {
    ""id"": 2063,
    ""label"": ""Outpatient Care Centers"",
    ""hierarchy"": ""Hospitals and Health Care > Medical Practices > Outpatient Care Centers"",
    ""description"": ""This industry includes entities with medical staff that provide general or specialized outpatient care (except family planning centers and outpatient mental health and substance abuse centers, which are in separate industries).""
  },
  {
    ""id"": 2054,
    ""label"": ""Physical, Occupational and Speech Therapists"",
    ""hierarchy"": ""Hospitals and Health Care > Medical Practices > Physical, Occupational and Speech Therapists"",
    ""description"": ""This industry includes independent health practitioners who provide physical therapy services to patients who require prevention, wellness or fitness services; plan and administer educational, recreational, and social activities designed to help patients or individuals with disabilities regain physical or mental functioning or adapt to their disabilities; or diagnose and treat speech, language, or hearing problems.""
  },
  {
    ""id"": 2040,
    ""label"": ""Physicians"",
    ""hierarchy"": ""Hospitals and Health Care > Medical Practices > Physicians"",
    ""description"": ""This industry includes health practitioners having the degree of M.D. (Doctor of Medicine) or D.O. (Doctor of Osteopathy) practicing general or specialized medicine (e.g., anesthesiology, oncology, ophthalmology, psychiatry) or surgery. This category does not include clinics or hospitals.""
  },
  {
    ""id"": 2091,
    ""label"": ""Nursing Homes and Residential Care Facilities"",
    ""hierarchy"": ""Hospitals and Health Care > Nursing Homes and Residential Care Facilities"",
    ""description"": ""This industry includes entities that provide residential care combined with either nursing, supervisory, or other types of care as required by the residents.""
  },
  {
    ""id"": 25,
    ""label"": ""Manufacturing"",
    ""hierarchy"": ""Manufacturing"",
    ""description"": ""This industry includes entities that use mechanical, physical, or chemical transformation of materials, substances, or components to create new products. Included are entities that assemble component parts of manufactured products.""
  },
  {
    ""id"": 598,
    ""label"": ""Apparel Manufacturing"",
    ""hierarchy"": ""Manufacturing > Apparel Manufacturing"",
    ""description"": ""This industry includes entities that purchase fabric and cut and sew to make a garment, and those that first knit fabric and then cut and sew to make a garment. This includes apparel contractors that cut or sew on materials owned by others, jobbers who perform entrepreneurial functions in apparel manufacturing, and tailors who manufacture custom garments for individual clients.""
  },
  {
    ""id"": 615,
    ""label"": ""Fashion Accessories Manufacturing"",
    ""hierarchy"": ""Manufacturing > Apparel Manufacturing > Fashion Accessories Manufacturing"",
    ""description"": ""This industry includes entities that manufacture apparel and accessories (except apparel knitting mills and cut and sew apparel, which are in separate industries), including jobbers who perform entrepreneurial functions in apparel accessories manufacture. Example products include belts, caps, gloves (except medical, sporting, safety), hats, and neckties.""
  },
  {
    ""id"": 112,
    ""label"": ""Appliances, Electrical, and Electronics Manufacturing"",
    ""hierarchy"": ""Manufacturing > Appliances, Electrical, and Electronics Manufacturing"",
    ""description"": ""This industry includes entities that manufacture products that generate, distribute, and use electrical power, including small and major electrical appliances and parts; electric motors; devices for storing electrical power (e.g., batteries); for transmitting electricity (e.g., insulated wire); and wiring devices (e.g., electrical outlets, fuse boxes, and light switches).""
  },
  {
    ""id"": 998,
    ""label"": ""Electric Lighting Equipment Manufacturing"",
    ""hierarchy"": ""Manufacturing > Appliances, Electrical, and Electronics Manufacturing > Electric Lighting Equipment Manufacturing"",
    ""description"": ""This industry includes entities that manufacture 1. Electric light bulbs and tubes, and parts and components (except glass blanks for electric light bulbs, which are in separate industries) or 2. Electric lighting fixtures (except vehicular, which are in a separate industry), nonelectric lighting equipment, lamp shades (except glass and plastics, which are in separate industries), and lighting fixture components (except current-carrying wiring devices, which are in a separate industry).""
  },
  {
    ""id"": 2468,
    ""label"": ""Electrical Equipment Manufacturing"",
    ""hierarchy"": ""Manufacturing > Appliances, Electrical, and Electronics Manufacturing > Electrical Equipment Manufacturing"",
    ""description"": ""This industry includes entities that manufacture power, distribution, and specialty transformers; electric motors, generators, and motor generator sets; switchgear and switchboard apparatus; relays; and industrial controls.""
  },
  {
    ""id"": 3255,
    ""label"": ""Fuel Cell Manufacturing"",
    ""hierarchy"": ""Manufacturing > Appliances, Electrical, and Electronics Manufacturing > Electrical Equipment Manufacturing > Fuel Cell Manufacturing"",
    ""description"": ""This industry includes entities that manufacture electrochemical conversion devices that convert chemical energy from fuel sources into electricity.""
  },
  {
    ""id"": 1005,
    ""label"": ""Household Appliance Manufacturing"",
    ""hierarchy"": ""Manufacturing > Appliances, Electrical, and Electronics Manufacturing > Household Appliance Manufacturing"",
    ""description"": ""This industry includes entities that manufacture small electric appliances, electric housewares, and major household appliances.""
  },
  {
    ""id"": 54,
    ""label"": ""Chemical Manufacturing"",
    ""hierarchy"": ""Manufacturing > Chemical Manufacturing"",
    ""description"": ""This industry includes entities that transform organic and inorganic raw materials by a chemical process and formulate products. It includes the production of basic chemicals as well as intermediate and end products produced by further processing basic chemicals.""
  },
  {
    ""id"": 709,
    ""label"": ""Agricultural Chemical Manufacturing"",
    ""hierarchy"": ""Manufacturing > Chemical Manufacturing > Agricultural Chemical Manufacturing"",
    ""description"": ""This industry includes entities that manufacture: 1. Nitrogenous or phosphatic fertilizer materials with or without mixing with other ingredients into fertilizers; 2. Mixing ingredients made elsewhere into fertilizers; and 3. Fertilizers from sewage or animal waste. Included are entities that formulate and prepare pesticides and other agricultural chemicals.""
  },
  {
    ""id"": 703,
    ""label"": ""Artificial Rubber and Synthetic Fiber Manufacturing"",
    ""hierarchy"": ""Manufacturing > Chemical Manufacturing > Artificial Rubber and Synthetic Fiber Manufacturing"",
    ""description"": ""This industry includes entities that manufacture synthetic resins, plastics materials, and non-vulcanizable elastomers and mixing and blending resins; synthetic rubber; and cellulosic (e.g., rayon, acetate) and non-cellulosic (e.g., nylon, polyolefin, polyester) fibers, including in the form of monofilament, filament yarn, staple, or tow.""
  },
  {
    ""id"": 690,
    ""label"": ""Chemical Raw Materials Manufacturing"",
    ""hierarchy"": ""Manufacturing > Chemical Manufacturing > Chemical Raw Materials Manufacturing"",
    ""description"": ""This industry includes entities that manufacture chemicals using basic processes, such as thermal cracking and distillation. These chemicals are usually separate chemical elements or separate chemically-defined compounds.""
  },
  {
    ""id"": 722,
    ""label"": ""Paint, Coating, and Adhesive Manufacturing"",
    ""hierarchy"": ""Manufacturing > Chemical Manufacturing > Paint, Coating, and Adhesive Manufacturing"",
    ""description"": ""This industry includes entities that mix pigments, solvents, and binders into paints and other coatings, as well as those that manufacture allied paint products, adhesives, glues, and caulking compounds.""
  },
  {
    ""id"": 18,
    ""label"": ""Personal Care Product Manufacturing"",
    ""hierarchy"": ""Manufacturing > Chemical Manufacturing > Personal Care Product Manufacturing"",
    ""description"": ""This industry includes entities that prepare, blend, compound, and package toiletry preparations, such as perfumes, shaving preparations, hair preparations, face creams, lotions (including sunscreens), and other cosmetic preparations.""
  },
  {
    ""id"": 15,
    ""label"": ""Pharmaceutical Manufacturing"",
    ""hierarchy"": ""Manufacturing > Chemical Manufacturing > Pharmaceutical Manufacturing"",
    ""description"": ""This industry includes entities that: 1. Manufacture biological and medicinal products; 2. Process botanical drugs and herbs; 3. Isolate active medicinal principals from botanical drugs and herbs; and/or 4. Manufacture pharmaceutical products intended for internal and external consumption in such forms as ampoules, tablets, capsules, vials, ointments, powders, solutions, and suspensions.""
  },
  {
    ""id"": 727,
    ""label"": ""Soap and Cleaning Product Manufacturing"",
    ""hierarchy"": ""Manufacturing > Chemical Manufacturing > Soap and Cleaning Product Manufacturing"",
    ""description"": ""This industry includes entities that manufacture and package soaps and other cleaning compounds, surface active agents, and textile and leather finishing agents used to reduce tension or speed the drying process.""
  },
  {
    ""id"": 3251,
    ""label"": ""Climate Technology Product Manufacturing"",
    ""hierarchy"": ""Manufacturing > Climate Technology Products Manufacturing"",
    ""description"": ""This industry includes entities that research, develop, and produce technologies for the generation of renewable energy, alternative fuel cells, and sequestering carbon and other greenhouse gases from the atmosphere.""
  },
  {
    ""id"": 24,
    ""label"": ""Computers and Electronics Manufacturing"",
    ""hierarchy"": ""Manufacturing > Computers and Electronics Manufacturing"",
    ""description"": ""This industry includes entities that manufacture computers, computer peripherals, communications equipment, and similar electronic products, and entities that manufacture components for such products.""
  },
  {
    ""id"": 973,
    ""label"": ""Audio and Video Equipment Manufacturing"",
    ""hierarchy"": ""Manufacturing > Computers and Electronics Manufacturing > Audio and Video Equipment Manufacturing"",
    ""description"": ""This industry includes entities that manufacture electronic audio and video equipment for home entertainment, motor vehicles, and public address and musical instrument amplification.""
  },
  {
    ""id"": 964,
    ""label"": ""Communications Equipment Manufacturing"",
    ""hierarchy"": ""Manufacturing > Computers and Electronics Manufacturing > Communications Equipment Manufacturing"",
    ""description"": ""This industry includes entities that manufacture communications equipment such as wire telephone and data communications equipment, and radio or television broadcast and wireless communications equipment.""
  },
  {
    ""id"": 3,
    ""label"": ""Computer Hardware Manufacturing"",
    ""hierarchy"": ""Manufacturing > Computers and Electronics Manufacturing > Computer Hardware Manufacturing"",
    ""description"": ""This industry includes entities that manufacture or assemble electronic computers, such as mainframes, personal computers, workstations, laptops, and computer servers; and computer peripheral equipment, such as storage devices, printers, monitors, and input/output devices and terminals.""
  },
  {
    ""id"": 3245,
    ""label"": ""Accessible Hardware Manufacturing"",
    ""hierarchy"": ""Manufacturing > Computers and Electronics Manufacturing > Computer Hardware Manufacturing > Accessible Hardware Manufacturing"",
    ""description"": ""This industry includes entities that manufacture or assemble computer accessibility hardware, such as electronic pointing devices, touch screens and adaptive keyboards.""
  },
  {
    ""id"": 994,
    ""label"": ""Magnetic and Optical Media Manufacturing"",
    ""hierarchy"": ""Manufacturing > Computers and Electronics Manufacturing > Magnetic and Optical Media Manufacturing"",
    ""description"": ""This industry includes entities that manufacture optical and magnetic media, such as blank audio tapes, blank video tapes, and blank diskettes, and/or mass duplicate (such as, making copies) audio, video, software, and other data on magnetic, optical, and similar media.""
  },
  {
    ""id"": 983,
    ""label"": ""Measuring and Control Instrument Manufacturing"",
    ""hierarchy"": ""Manufacturing > Computers and Electronics Manufacturing > Measuring and Control Instrument Manufacturing"",
    ""description"": ""This industry includes entities that manufacture navigational, measuring, electromedical, and control instruments. Examples of products made by these entities are aeronautical instruments, appliance regulators and controls (except switches, which are in a separate industry), laboratory analytical instruments, navigation and guidance systems, and physical properties testing equipment.""
  },
  {
    ""id"": 3254,
    ""label"": ""Smart Meter Manufacturing"",
    ""hierarchy"": ""Manufacturing > Computers and Electronics Manufacturing > Measuring and Control Instrument Manufacturing > Smart Meter Manufacturing"",
    ""description"": ""This industry includes entities that manufacture electronic metering devices that measure and record utility usage in real-time and enable two way communication with utility providers.""
  },
  {
    ""id"": 7,
    ""label"": ""Semiconductor Manufacturing"",
    ""hierarchy"": ""Manufacturing > Computers and Electronics Manufacturing > Semiconductor Manufacturing"",
    ""description"": ""This industry includes entities that manufacture semiconductors and other components for electronic applications.""
  },
  {
    ""id"": 144,
    ""label"": ""Renewable Energy Semiconductor Manufacturing"",
    ""hierarchy"": ""Manufacturing > Computers and Electronics Manufacturing > Semiconductor Manufacturing > Renewable Energy Semiconductor Manufacturing"",
    ""description"": ""This industry includes entities that manufacture semiconductors and other components for use in photovoltaic cells and other renewable energy applications.""
  },
  {
    ""id"": 840,
    ""label"": ""Fabricated Metal Products"",
    ""hierarchy"": ""Manufacturing > Fabricated Metal Products"",
    ""description"": ""This industry includes entities that transform metal into intermediate or end products, or treat metals and metal formed products fabricated elsewhere. This industry does not include machinery, computers and electronics, or metal furniture. This industry includes firearms manufacturing.""
  },
  {
    ""id"": 852,
    ""label"": ""Architectural and Structural Metal Manufacturing"",
    ""hierarchy"": ""Manufacturing > Fabricated Metal Products > Architectural and Structural Metal Manufacturing"",
    ""description"": ""This industry includes entities that manufacture one or more of the following: 1. Prefabricated metal buildings, panels and sections; 2. Structural metal products; 3. Metal plate work products; 4. Metal framed windows (such as, typically using purchased glass) and metal doors; 5. Sheet metal work; and 6. Ornamental and architectural metal products.""
  },
  {
    ""id"": 861,
    ""label"": ""Boilers, Tanks, and Shipping Container Manufacturing"",
    ""hierarchy"": ""Manufacturing > Fabricated Metal Products > Boilers, Tanks, and Shipping Container Manufacturing"",
    ""description"": ""This industry includes entities that: 1. Manufacture power boilers and heat exchangers; 2. Cut, form, and join heavy gauge metal to manufacture tanks, vessels, and other containers; or 3. Form light gauge metal containers.""
  },
  {
    ""id"": 871,
    ""label"": ""Construction Hardware Manufacturing"",
    ""hierarchy"": ""Manufacturing > Fabricated Metal Products > Construction Hardware Manufacturing"",
    ""description"": ""This industry includes entities that manufacture metal hardware, such as metal hinges, metal handles, keys, and locks (except coin-operated or time locks, which are in separate industries).""
  },
  {
    ""id"": 849,
    ""label"": ""Cutlery and Handtool Manufacturing"",
    ""hierarchy"": ""Manufacturing > Fabricated Metal Products > Cutlery and Handtool Manufacturing"",
    ""description"": ""This industry includes entities that manufacture one or more of the following: 1. Metal kitchen cookware (except by casting (e.g., cast iron skillets) or stamped without further fabrication), utensils, and/or nonprecious and precious plated metal cutlery and flatware; 2. Saw blades, all types (including those for power sawing machines); and 3. Nonpowered handtools and edge tools.""
  },
  {
    ""id"": 883,
    ""label"": ""Metal Treatments"",
    ""hierarchy"": ""Manufacturing > Fabricated Metal Products > Metal Treatments"",
    ""description"": ""This industry includes entities that perform one or more of the following services for metals and metal products: 1. Heat treating; 2. Enameling, lacquering, and varnishing; 3.Hot dip galvanizing; 4. Engraving, chasing, or etching; 5. Powder coating; 6. Electroplating, plating, anodizing, coloring, and finishing; and 7. Other metal surfacing services.""
  },
  {
    ""id"": 887,
    ""label"": ""Metal Valve, Ball, and Roller Manufacturing"",
    ""hierarchy"": ""Manufacturing > Fabricated Metal Products > Metal Valve, Ball, and Roller Manufacturing"",
    ""description"": ""This industry includes entities that manufacture fabricated metal products like valves, balls, and rollers (except forgings and stampings, cutlery and handtools, architectural and structural metals, boilers, tanks, shipping containers, hardware, spring and wire products, machine shop products, turned products, screws, and nuts and bolts, which are in separate industries).""
  },
  {
    ""id"": 873,
    ""label"": ""Spring and Wire Product Manufacturing"",
    ""hierarchy"": ""Manufacturing > Fabricated Metal Products > Spring and Wire Product Manufacturing"",
    ""description"": ""This industry includes entities that manufacture steel springs by forming, such as cutting, bending, and heat winding, metal rod or strip stock and/or wire springs and fabricated wire products from wire drawn elsewhere (except watch and clock springs, which are in separate industries).""
  },
  {
    ""id"": 876,
    ""label"": ""Turned Products and Fastener Manufacturing"",
    ""hierarchy"": ""Manufacturing > Fabricated Metal Products > Turned Products and Fastener Manufacturing"",
    ""description"": ""This industry includes entities involved in one of the following: 1. Operating machine shops for machining metal and plastic parts and parts of other composite materials on a job or order basis; 2. Machining precision turned products; or 3. Manufacturing metal bolts, nuts, screws, rivets, and other industrial fasteners.""
  },
  {
    ""id"": 23,
    ""label"": ""Food and Beverage Manufacturing"",
    ""hierarchy"": ""Manufacturing > Food and Beverage Manufacturing"",
    ""description"": ""This industry includes entities that transform livestock and agricultural products into products for intermediate or final consumption, typically sold to wholesalers or retailers for distribution to consumers; retailers of bakery and candy products made on the premises not for immediate consumption are included.""
  },
  {
    ""id"": 562,
    ""label"": ""Breweries"",
    ""hierarchy"": ""Manufacturing > Food and Beverage Manufacturing > Breweries"",
    ""description"": ""This industry includes entities that brew beer, ale, lager, malt liquors, and nonalcoholic beer.""
  },
  {
    ""id"": 564,
    ""label"": ""Distilleries"",
    ""hierarchy"": ""Manufacturing > Food and Beverage Manufacturing > Distilleries"",
    ""description"": ""This industry includes entities that distill potable liquors (except brandies, which are in a separate industry), distill and blend liquors, and/or blend and mix liquors and other ingredients.""
  },
  {
    ""id"": 2500,
    ""label"": ""Wineries"",
    ""hierarchy"": ""Manufacturing > Food and Beverage Manufacturing > Wineries"",
    ""description"": ""This industry includes entities that focus on one or more of the following: 1. Growing grapes and manufacturing wines and brandies; 2. Manufacturing wines and brandies from grapes and other fruits grown elsewhere; and 3. Blending wines and brandies.""
  },
  {
    ""id"": 481,
    ""label"": ""Animal Feed Manufacturing"",
    ""hierarchy"": ""Manufacturing > Food and Beverage Manufacturing > Animal Feed Manufacturing"",
    ""description"": ""This industry includes entities that manufacture food and feed for animals from ingredients, such as grains, oilseed mill products, and meat products.""
  },
  {
    ""id"": 529,
    ""label"": ""Baked Goods Manufacturing"",
    ""hierarchy"": ""Manufacturing > Food and Beverage Manufacturing > Baked Goods Manufacturing"",
    ""description"": ""This industry includes entities that: 1. Manufacture fresh and frozen bread and other bakery products; 2. Retail bread and other bakery products not for immediate consumption made on the premises from flour, not from prepared dough; or 3. Manufacture cookies, crackers, dry pasta, tortillas, or prepared flour mixes or dough from flour ground elsewhere.""
  },
  {
    ""id"": 142,
    ""label"": ""Beverage Manufacturing"",
    ""hierarchy"": ""Manufacturing > Food and Beverage Manufacturing > Beverage Manufacturing"",
    ""description"": ""This industry includes entities that manufacture soft drinks and ice; purify and bottle water; and manufacture brewery, winery, and distillery products.""
  },
  {
    ""id"": 65,
    ""label"": ""Dairy Product Manufacturing"",
    ""hierarchy"": ""Manufacturing > Food and Beverage Manufacturing > Dairy Product Manufacturing"",
    ""description"": ""This industry includes entities that manufacture dairy products from raw milk, processed milk, and dairy substitutes.""
  },
  {
    ""id"": 504,
    ""label"": ""Fruit and Vegetable Preserves Manufacturing"",
    ""hierarchy"": ""Manufacturing > Food and Beverage Manufacturing > Fruit and Vegetable Preserves Manufacturing"",
    ""description"": ""This industry includes entities that freeze food and use preservation processes such as pickling, canning, and dehydrating. Production processes begin with inputs of vegetable or animal origin.""
  },
  {
    ""id"": 521,
    ""label"": ""Meat Products Manufacturing"",
    ""hierarchy"": ""Manufacturing > Food and Beverage Manufacturing > Meat Products Manufacturing"",
    ""description"": ""This industry includes entities that slaughter animals, prepare processed meats and meat byproducts, and render and/or refine animal fat, bones, and meat scraps. Entities that assembly cut and pack meats (such as, boxed meats) from purchased carcasses are included.""
  },
  {
    ""id"": 528,
    ""label"": ""Seafood Product Manufacturing"",
    ""hierarchy"": ""Manufacturing > Food and Beverage Manufacturing > Seafood Product Manufacturing"",
    ""description"": ""This industry includes entities that: 1. Can seafood (including soup); 2. Smoke, salt, and dry seafood; 3. Eviscerate fresh fish by removing heads, fins, scales, bones, and entrails; 4. Shuck and pack fresh shellfish; 5. Process marine fats and oils; and 6. Freeze seafood. Factory ships that gather and process seafood into canned seafood products are included.""
  },
  {
    ""id"": 495,
    ""label"": ""Sugar and Confectionery Product Manufacturing"",
    ""hierarchy"": ""Manufacturing > Food and Beverage Manufacturing > Sugar and Confectionery Product Manufacturing"",
    ""description"": ""This industry includes entities that process agricultural inputs, such as sugarcane, beet, and cacao, to give rise to a new product (sugar or chocolate) and those that begin with sugar and chocolate and process these further.""
  },
  {
    ""id"": 26,
    ""label"": ""Furniture and Home Furnishings Manufacturing"",
    ""hierarchy"": ""Manufacturing > Furniture and Home Furnishings Manufacturing"",
    ""description"": ""This industry includes entities that make furniture and related articles, such as mattresses, window blinds, cabinets, and fixtures. Design may be performed by the entity's workforce or may be purchased from industrial designers.""
  },
  {
    ""id"": 1080,
    ""label"": ""Household and Institutional Furniture Manufacturing"",
    ""hierarchy"": ""Manufacturing > Furniture and Home Furnishings Manufacturing > Household and Institutional Furniture Manufacturing"",
    ""description"": ""This industry includes entities that manufacture household-type furniture, such as living room, kitchen and bedroom furniture and institutional (such as, public building) furniture, such as furniture for schools, theaters, and churches.""
  },
  {
    ""id"": 1095,
    ""label"": ""Mattress and Blinds Manufacturing"",
    ""hierarchy"": ""Manufacturing > Furniture and Home Furnishings Manufacturing > Mattress and Blinds Manufacturing"",
    ""description"": ""This industry includes entities that manufacture furniture related products, such as mattresses, blinds, and shades.""
  },
  {
    ""id"": 1090,
    ""label"": ""Office Furniture and Fixtures Manufacturing"",
    ""hierarchy"": ""Manufacturing > Furniture and Home Furnishings Manufacturing > Office Furniture and Fixtures Manufacturing"",
    ""description"": ""This industry includes entities that manufacture office furniture and/or office and store fixtures on a stock or custom basis that may be assembled or unassembled (such as, knockdown).""
  },
  {
    ""id"": 145,
    ""label"": ""Glass, Ceramics and Concrete Manufacturing"",
    ""hierarchy"": ""Manufacturing > Glass, Ceramics and Concrete Manufacturing"",
    ""description"": ""This industry includes entities that transform mined or quarried nonmetallic minerals, such as sand, gravel, stone, clay, and refractory materials, into products for intermediate or final consumption.""
  },
  {
    ""id"": 799,
    ""label"": ""Abrasives and Nonmetallic Minerals Manufacturing"",
    ""hierarchy"": ""Manufacturing > Glass, Ceramics and Concrete Manufacturing > Abrasives and Nonmetallic Minerals Manufacturing"",
    ""description"": ""This industry includes entities that manufacture nonmetallic mineral products (except clay products, refractory products, glass products, cement and concrete products, lime, and gypsum products, which are in separate industries).""
  },
  {
    ""id"": 773,
    ""label"": ""Clay and Refractory Products Manufacturing"",
    ""hierarchy"": ""Manufacturing > Glass, Ceramics and Concrete Manufacturing > Clay and Refractory Products Manufacturing"",
    ""description"": ""This industry includes entities that shape, mold, glaze, and fire pottery, ceramics, and plumbing fixtures, and electrical supplies made entirely or partly of clay or other ceramic materials or shape, mold, bake, burn, or harden clay refractories, nonclay refractories, ceramic tile, structural clay tile, brick, and other structural clay building materials.""
  },
  {
    ""id"": 779,
    ""label"": ""Glass Product Manufacturing"",
    ""hierarchy"": ""Manufacturing > Glass, Ceramics and Concrete Manufacturing > Glass Product Manufacturing"",
    ""description"": ""This industry includes entities that manufacture glass and/or glass products by melting silica sand or cullet, or from purchased glass.""
  },
  {
    ""id"": 794,
    ""label"": ""Lime and Gypsum Products Manufacturing"",
    ""hierarchy"": ""Manufacturing > Glass, Ceramics and Concrete Manufacturing > Lime and Gypsum Products Manufacturing"",
    ""description"": ""This industry includes entities that manufacture lime from calcitic limestone, dolomitic limestone, or other calcareous materials or manufacturing gypsum products.""
  },
  {
    ""id"": 616,
    ""label"": ""Leather Product Manufacturing"",
    ""hierarchy"": ""Manufacturing > Leather Product Manufacturing"",
    ""description"": ""This industry includes entities that transform hides into leather by tanning or curing and fabricating the leather into products (except apparel, which is in a separate industry). Included is the manufacture of similar products made from leather substitutes, such as rubber footwear, textile luggage, and plastic wallets.""
  },
  {
    ""id"": 622,
    ""label"": ""Footwear Manufacturing"",
    ""hierarchy"": ""Manufacturing > Leather Product Manufacturing > Footwear Manufacturing"",
    ""description"": ""This industry includes entities that manufacture footwear (except orthopedic extension footwear, which is in a separate industry).""
  },
  {
    ""id"": 625,
    ""label"": ""Women's Handbag Manufacturing"",
    ""hierarchy"": ""Manufacturing > Leather Product Manufacturing > Women's Handbag Manufacturing"",
    ""description"": ""This industry includes entities that manufacture women's handbags and purses of any material (except precious metal, which is in a separate industry).""
  },
  {
    ""id"": 55,
    ""label"": ""Machinery Manufacturing"",
    ""hierarchy"": ""Manufacturing > Machinery Manufacturing"",
    ""description"": ""This industry includes entities that create end products that apply mechanical force, for example, the application of gears and levers, to perform work.""
  },
  {
    ""id"": 901,
    ""label"": ""Agriculture, Construction, Mining Machinery Manufacturing"",
    ""hierarchy"": ""Manufacturing > Machinery Manufacturing > Agriculture, Construction, Mining Machinery Manufacturing"",
    ""description"": ""This industry includes entities that manufacture one or more of the following: 1. Farm machinery and equipment, power mowing equipment, and other powered home lawn and garden equipment; 2. Construction machinery, surface mining machinery, and logging equipment; and 3. Oil and gas field and underground mining machinery and equipment.""
  },
  {
    ""id"": 147,
    ""label"": ""Automation Machinery Manufacturing"",
    ""hierarchy"": ""Manufacturing > Machinery Manufacturing > Automation Machinery Manufacturing"",
    ""description"": ""This industry includes entities that use control systems for machinery, processes in factories, and human-machine interfaces with minimal or reduced human intervention. Control systems can be discrete, sequential, or computerized, and range in complexity from household temperature control to large industrial systems with multi-variable high-level algorithms. Artificial neural networks, motion control, and robotics are included.""
  },
  {
    ""id"": 3247,
    ""label"": ""Robot Manufacturing"",
    ""hierarchy"": ""Manufacturing > Machinery Manufacturing > Automation Machinery Manufacturing > Robot Manufacturing"",
    ""description"": ""This industry includes entities that manufacture autonomous or semi-autonomous robots.""
  },
  {
    ""id"": 918,
    ""label"": ""Commercial and Service Industry Machinery Manufacturing"",
    ""hierarchy"": ""Manufacturing > Machinery Manufacturing > Commercial and Service Industry Machinery Manufacturing"",
    ""description"": ""This industry includes entities that manufacture commercial and service industry machinery, such as optical instruments, photographic and photocopying equipment, automatic vending machinery, commercial laundry and drycleaning machinery, office machinery, automotive maintenance equipment (except mechanic's handtools, which are in separate industries), and commercial-type cooking equipment.""
  },
  {
    ""id"": 935,
    ""label"": ""Engines and Power Transmission Equipment Manufacturing"",
    ""hierarchy"": ""Manufacturing > Machinery Manufacturing > Engines and Power Transmission Equipment Manufacturing"",
    ""description"": ""This industry includes entities that manufacture turbines, power transmission equipment, and internal combustion engines (except automotive, gasoline and aircraft, which are in separate industries).""
  },
  {
    ""id"": 3241,
    ""label"": ""Renewable Energy Equipment Manufacturing"",
    ""hierarchy"": ""Manufacturing > Machinery Manufacturing > Engines and Power Transmission Equipment Manufacturing > Renewable Energy Equipment Manufacturing"",
    ""description"": ""This industry includes entities that manufacture renewable energy machinery and equipment.""
  },
  {
    ""id"": 923,
    ""label"": ""HVAC and Refrigeration Equipment Manufacturing"",
    ""hierarchy"": ""Manufacturing > Machinery Manufacturing > HVAC and Refrigeration Equipment Manufacturing"",
    ""description"": ""This industry includes entities that manufacture ventilating, heating, air-conditioning, and commercial or industrial refrigeration and freezer equipment.""
  },
  {
    ""id"": 135,
    ""label"": ""Industrial Machinery Manufacturing"",
    ""hierarchy"": ""Manufacturing > Machinery Manufacturing > Industrial Machinery Manufacturing"",
    ""description"": ""This industry includes entities that manufacture industrial machinery, such as food and beverage manufacturing machinery, semiconductor manufacturing machinery, sawmill and woodworking machinery (except handheld), machinery for making paper and paper products, printing and binding machinery and equipment, textile making machinery, and machinery for making plastics and rubber products.""
  },
  {
    ""id"": 928,
    ""label"": ""Metalworking Machinery Manufacturing"",
    ""hierarchy"": ""Manufacturing > Machinery Manufacturing > Metalworking Machinery Manufacturing"",
    ""description"": ""This industry includes entities that manufacture metalworking machinery, such as metal cutting and metal forming machine tools; cutting tools; accessories for metalworking machinery; special dies, tools, jigs, and fixtures; industrial molds; rolling mill machinery; assembly machinery; coil handling, conversion, or straightening equipment; and wire drawing and fabricating machines.""
  },
  {
    ""id"": 17,
    ""label"": ""Medical Equipment Manufacturing"",
    ""hierarchy"": ""Manufacturing > Medical Equipment Manufacturing"",
    ""description"": ""This industry includes entities that manufacture medical equipment and supplies. Example products include surgical and medical instruments, surgical appliances and supplies, dental equipment and supplies, orthodontic goods, ophthalmic goods, dentures, and orthodontic appliances.""
  },
  {
    ""id"": 679,
    ""label"": ""Oil and Coal Product Manufacturing"",
    ""hierarchy"": ""Manufacturing > Oil and Coal Product Manufacturing"",
    ""description"": ""This industry includes entities that transform crude petroleum and coal into usable products, as well as entities that further process refined petroleum and coal products to produce products such as asphalt coatings and petroleum lubricating oils.""
  },
  {
    ""id"": 61,
    ""label"": ""Paper and Forest Product Manufacturing"",
    ""hierarchy"": ""Manufacturing > Paper and Forest Product Manufacturing"",
    ""description"": ""This industry includes entities that make pulp, paper, or converted paper products.""
  },
  {
    ""id"": 743,
    ""label"": ""Plastics and Rubber Product Manufacturing"",
    ""hierarchy"": ""Manufacturing > Plastics and Rubber Product Manufacturing"",
    ""description"": ""This industry includes entities that make goods by processing plastics materials and raw rubber, generally restricted to products made solely of plastics or rubber.""
  },
  {
    ""id"": 146,
    ""label"": ""Packaging and Containers Manufacturing"",
    ""hierarchy"": ""Manufacturing > Plastics and Rubber Product Manufacturing > Packaging and Containers Manufacturing"",
    ""description"": ""This industry includes entities that convert plastics resins into plastics packaging (flexible) film and packaging sheet.""
  },
  {
    ""id"": 117,
    ""label"": ""Plastics Manufacturing"",
    ""hierarchy"": ""Manufacturing > Plastics and Rubber Product Manufacturing > Plastics Manufacturing"",
    ""description"": ""This industry includes entities that process new or spent (such as, recycled) plastics resins into intermediate or final products, using such processes as compression molding, extrusion molding, injection molding, blow molding, and casting.""
  },
  {
    ""id"": 763,
    ""label"": ""Rubber Products Manufacturing"",
    ""hierarchy"": ""Manufacturing > Plastics and Rubber Product Manufacturing > Rubber Products Manufacturing"",
    ""description"": ""This industry includes entities that process natural, synthetic, or reclaimed rubber materials into intermediate or final products using processes, such as vulcanizing, cementing, molding, extruding, and lathe-cutting.""
  },
  {
    ""id"": 807,
    ""label"": ""Primary Metal Manufacturing"",
    ""hierarchy"": ""Manufacturing > Primary Metal Manufacturing"",
    ""description"": ""This industry includes entities that smelt and/or refine ferrous and nonferrous metals from ore, pig or scrap, using electrometallurgical and other process metallurgical techniques.""
  },
  {
    ""id"": 83,
    ""label"": ""Printing Services"",
    ""hierarchy"": ""Manufacturing > Printing Services"",
    ""description"": ""This industry includes entities that print on apparel and textile products, paper, metal, glass, plastics, and other materials, except fabric (grey goods).""
  },
  {
    ""id"": 20,
    ""label"": ""Sporting Goods Manufacturing"",
    ""hierarchy"": ""Manufacturing > Sporting Goods Manufacturing"",
    ""description"": ""This industry includes entities that manufacture sporting and athletic goods (except apparel and footwear).""
  },
  {
    ""id"": 60,
    ""label"": ""Textile Manufacturing"",
    ""hierarchy"": ""Manufacturing > Textile Manufacturing"",
    ""description"": ""This industry includes entities that transform a basic fiber (natural or synthetic) into a product, such as yarn or fabric that is further manufactured into usable items, such as sheets, towels, and textile bags for individual or industrial consumption.""
  },
  {
    ""id"": 21,
    ""label"": ""Tobacco Manufacturing"",
    ""hierarchy"": ""Manufacturing > Tobacco Manufacturing"",
    ""description"": ""This industry includes entities that stem and redry tobacco and/or manufacture cigarettes and other tobacco products.""
  },
  {
    ""id"": 1029,
    ""label"": ""Transportation Equipment Manufacturing"",
    ""hierarchy"": ""Manufacturing > Transportation Equipment Manufacturing"",
    ""description"": ""This industry includes entities that manufacture equipment for transporting people and goods.""
  },
  {
    ""id"": 52,
    ""label"": ""Aviation and Aerospace Component Manufacturing"",
    ""hierarchy"": ""Manufacturing > Transportation Equipment Manufacturing > Aviation and Aerospace Component Manufacturing"",
    ""description"": ""This industry includes entities that: 1. Manufacture complete aircraft, missiles, or space vehicles; 2. Manufacture aerospace engines, propulsion units, auxiliary equipment or parts; 3. Develop and make prototypes of aerospace products; 4. Make major modifications to aircraft systems; and 5. Overhaul and rebuild complete aircraft or propulsion systems.""
  },
  {
    ""id"": 1,
    ""label"": ""Defense and Space Manufacturing"",
    ""hierarchy"": ""Manufacturing > Transportation Equipment Manufacturing > Defense and Space Manufacturing"",
    ""description"": ""This industry includes entities that manufacture complete guided missiles and space vehicles and/or develop prototypes.""
  },
  {
    ""id"": 53,
    ""label"": ""Motor Vehicle Manufacturing"",
    ""hierarchy"": ""Manufacturing > Transportation Equipment Manufacturing > Motor Vehicle Manufacturing"",
    ""description"": ""This industry includes entities that manufacture complete automobiles, light duty motor vehicles, and heavy duty trucks (such as, body and chassis or unibody) or manufacture motor vehicle chassis only.""
  },
  {
    ""id"": 3253,
    ""label"": ""Alternative Fuel Vehicle Manufacturing"",
    ""hierarchy"": ""Manufacturing > Transportation Equipment Manufacturing > Motor Vehicle Manufacturing > Alternative Fuel Vehicle Manufacturing"",
    ""description"": ""This industry includes entities that manufacture motor vehicles powered by fuels other than gasoline or diesel, such as electricity, natural gas, propane, hydrogen, and biofuels. Electric and hybrid vehicles are included in this industry.""
  },
  {
    ""id"": 1042,
    ""label"": ""Motor Vehicle Parts Manufacturing"",
    ""hierarchy"": ""Manufacturing > Transportation Equipment Manufacturing > Motor Vehicle Parts Manufacturing"",
    ""description"": ""This industry includes entities that manufacture motor vehicle gasoline engines and engine parts, motor vehicle electrical and electronic equipment, motor vehicle steering and suspension components (except springs), motor vehicle brake systems, motor vehicle transmission and power train parts, motor vehicle seating and interior trim, motor vehicle metal stampings, and other motor vehicle parts and accessories.""
  },
  {
    ""id"": 62,
    ""label"": ""Railroad Equipment Manufacturing"",
    ""hierarchy"": ""Manufacturing > Transportation Equipment Manufacturing > Railroad Equipment Manufacturing"",
    ""description"": ""This industry includes entities that: 1. Manufacture and/or rebuild locomotives, locomotive frames and parts; 2. Manufacture railroad, street, and rapid transit cars and car equipment for freight and passenger rail service; and 3. Manufacture rail layers, ballast distributors, rail tamping equipment and other railway track maintenance equipment.""
  },
  {
    ""id"": 58,
    ""label"": ""Shipbuilding"",
    ""hierarchy"": ""Manufacturing > Transportation Equipment Manufacturing > Shipbuilding"",
    ""description"": ""This industry includes entities that operate shipyards or boatyards (such as, ship or boat manufacturing facilities). Activities include the construction of ships, their repair, conversion and alteration, production of prefabricated ship and barge sections, and specialized services such as ship scaling.""
  },
  {
    ""id"": 784,
    ""label"": ""Wood Product Manufacturing"",
    ""hierarchy"": ""Manufacturing > Wood Product Manufacturing"",
    ""description"": ""This industry includes entities that manufacture wood products, such as lumber, plywood, veneers, wood containers, wood flooring, wood trusses, manufactured homes (such as, mobile homes), and prefabricated wood buildings.""
  },
  {
    ""id"": 332,
    ""label"": ""Oil, Gas, and Mining"",
    ""hierarchy"": ""Oil, Gas, and Mining"",
    ""description"": ""This industry includes entities that extract naturally occurring mineral solids, such as coal and ores; liquid minerals, such as crude petroleum; and gases, such as natural gas. Included are entities that provide quarrying, well operations, and other preparation customarily performed as a part of mining activity.""
  },
  {
    ""id"": 56,
    ""label"": ""Mining"",
    ""hierarchy"": ""Oil, Gas, and Mining > Mining"",
    ""description"": ""This industry includes entities that mine, develop mine sites, and prepare metallic minerals and nonmetallic minerals, including coal.""
  },
  {
    ""id"": 341,
    ""label"": ""Coal Mining"",
    ""hierarchy"": ""Oil, Gas, and Mining > Mining > Coal Mining"",
    ""description"": ""This industry includes entities that: 1. Mine bituminous coal, anthracite, and lignite by underground mining, auger mining, strip mining, culm bank mining, and other surface mining; 2. Develop coal mine sites; and 3. Beneficiate coal (e.g., clean, wash, screen, and size coal).""
  },
  {
    ""id"": 345,
    ""label"": ""Metal Ore Mining"",
    ""hierarchy"": ""Oil, Gas, and Mining > Mining > Metal Ore Mining"",
    ""description"": ""This industry includes entities that develop mine sites or mine metallic minerals, and those that dress ore or beneficiate (e.g., crush, grind, wash, dry, sinter, concentrate, calcine, and leach).""
  },
  {
    ""id"": 356,
    ""label"": ""Nonmetallic Mineral Mining"",
    ""hierarchy"": ""Oil, Gas, and Mining > Mining > Nonmetallic Mineral Mining"",
    ""description"": ""This industry includes entities that develop mine sites, or mine or quarry nonmetallic minerals (except fuels, which are in a separate industry). Included are certain well and brine operations, and preparation plants that beneficiate (e.g., crush, grind, wash, and concentrate) nonmetallic minerals.""
  },
  {
    ""id"": 57,
    ""label"": ""Oil and Gas"",
    ""hierarchy"": ""Oil, Gas, and Mining > Oil and Gas"",
    ""description"": ""This industry includes entities that operate and/or develop oil and gas field properties. Crude petroleum production, extraction of oil from oil shale and oil sands, production of natural gas, sulfur recovery from natural gas, and recovery of hydrocarbon liquids are included.""
  },
  {
    ""id"": 3096,
    ""label"": ""Natural Gas Extraction"",
    ""hierarchy"": ""Oil, Gas, and Mining > Oil and Gas > Natural Gas Extraction"",
    ""description"": ""This industry includes entities that focus on the exploration, development, and/or the production of natural gas from wells in which the hydrocarbons will initially flow or can be produced using normal or enhanced drilling and extraction techniques or the recovery of liquid hydrocarbons from oil and gas field gases.""
  },
  {
    ""id"": 3095,
    ""label"": ""Oil Extraction"",
    ""hierarchy"": ""Oil, Gas, and Mining > Oil and Gas > Oil Extraction"",
    ""description"": ""This industry includes entities that focus on the exploration, development, and/or the production of petroleum from wells in which the hydrocarbons will initially flow or can be produced using normal or enhanced drilling and extraction techniques or on the production of crude petroleum from surface shales or tar sands or from reservoirs in which the hydrocarbons are semisolids.""
  },
  {
    ""id"": 1810,
    ""label"": ""Professional Services"",
    ""hierarchy"": ""Professional Services"",
    ""description"": ""This industry includes entities that perform professional, scientific, and technical activities for others, including legal advice and representation; accounting, bookkeeping, and payroll services; architectural, engineering, and specialized design services; computer services; consulting services; research services; advertising services; photographic services; translation and interpretation services; veterinary services; and other professional, scientific, and technical services.""
  },
  {
    ""id"": 47,
    ""label"": ""Accounting"",
    ""hierarchy"": ""Professional Services > Accounting"",
    ""description"": ""This industry includes entities that make accounting record audits, design accounting systems, prepare financial statements, develop budgets, prepare tax returns, process payroll, and perform bookkeeping and billing.""
  },
  {
    ""id"": 80,
    ""label"": ""Advertising Services"",
    ""hierarchy"": ""Professional Services > Advertising Services"",
    ""description"": ""This industry includes entities that provide advertising, public relations, and related services, such as the purchase of media, independent media representation, outdoor advertisement, direct mail advertisement, and advertisement material distribution services.""
  },
  {
    ""id"": 148,
    ""label"": ""Government Relations Services"",
    ""hierarchy"": ""Professional Services > Advertising Services > Government Relations Services"",
    ""description"": ""This industry includes entities aimed at impacting public policy at all levels of governance (local, regional, national and international) in order to promote the interests of a particular organization or group of organizations.""
  },
  {
    ""id"": 98,
    ""label"": ""Public Relations and Communications Services"",
    ""hierarchy"": ""Professional Services > Advertising Services > Public Relations and Communications Services"",
    ""description"": ""This industry includes entities that design and implement public relations campaigns, such as, campaigns to promote the interests and image of their clients. This includes lobbying, political consulting, and public relations consulting.""
  },
  {
    ""id"": 97,
    ""label"": ""Market Research"",
    ""hierarchy"": ""Professional Services > Advertising Services> Market Research"",
    ""description"": ""This industry includes entities that systematically gather, record, tabulate, and present marketing and public opinion data.""
  },
  {
    ""id"": 50,
    ""label"": ""Architecture and Planning"",
    ""hierarchy"": ""Professional Services > Architecture and Planning"",
    ""description"": ""This industry includes entities that plan and design residential, institutional, leisure, commercial, and industrial buildings and structures by applying knowledge of design, construction procedures, zoning regulations, building codes, and building materials.""
  },
  {
    ""id"": 3246,
    ""label"": ""Accessible Architecture and Design"",
    ""hierarchy"": ""Professional Services > Architecture and Planning > Accessible Architecture and Design"",
    ""description"": ""This industry includes entities that plan and design residential, institutional, leisure, commercial, and industrial buildings and structures that can be accessed, understood and used by all people regardless of their ability, disability or impairment.""
  },
  {
    ""id"": 11,
    ""label"": ""Business Consulting and Services"",
    ""hierarchy"": ""Professional Services > Business Consulting and Services"",
    ""description"": ""This industry includes entities that provide advice and assistance to businesses and other organizations on administrative and operational issues, such as strategic and organizational planning; financial planning and budgeting; marketing objectives and policies; human resource policies, practices, and planning; production scheduling, control planning, and IT Consulting.""
  },
  {
    ""id"": 86,
    ""label"": ""Environmental Services"",
    ""hierarchy"": ""Professional Services > Business Consulting and Services > Environmental Services"",
    ""description"": ""This industry includes entities that provide advice and assistance to businesses and organizations on environmental issues, such as control of environmental contamination from pollutants, toxic substances, and hazardous materials. They employ experts in fields such as air and water quality, asbestos contamination, remediation, ecological restoration, and environmental law. Sanitation or site remediation consulting services are included.""
  },
  {
    ""id"": 137,
    ""label"": ""Human Resources Services"",
    ""hierarchy"": ""Professional Services > Business Consulting and Services > Human Resources Services"",
    ""description"": ""This industry includes entities that provide advice and assistance to businesses and organizations in: 1. Human resource and personnel policies, practices, and procedures; 2. Employee benefits planning, communication, and administration; 3. Compensation systems planning; and/or 4. Wage and salary administration. Outsourcing firms that provide human resources services to their clients are not included in this industry.""
  },
  {
    ""id"": 1862,
    ""label"": ""Marketing Services"",
    ""hierarchy"": ""Professional Services > Business Consulting and Services > Marketing Services"",
    ""description"": ""This industry includes entities that provide operating advice and assistance to businesses and other organizations on marketing issues, such as developing marketing objectives and policies, sales forecasting, new product development and pricing, licensing and franchise planning, and marketing planning and strategy.""
  },
  {
    ""id"": 2401,
    ""label"": ""Operations Consulting"",
    ""hierarchy"": ""Professional Services > Business Consulting and Services > Operations Consulting"",
    ""description"": ""This industry includes entities that provide operating advice and assistance to businesses and other organizations in: 1. Manufacturing operations improvement; 2. Productivity improvement; 3. Production planning and control; 4. Quality assurance and quality control; 5. Inventory management; 6. Distribution networks; 7.Warehouse use, operations, and utilization; 8. Transportation and shipment of goods and materials; and 9. Materials management and handling.""
  },
  {
    ""id"": 123,
    ""label"": ""Outsourcing and Offshoring Consulting"",
    ""hierarchy"": ""Professional Services > Business Consulting and Services > Outsourcing and Offshoring Consulting"",
    ""description"": ""This industry includes entities that provide operating advice on the practice of outsourcing and/or offshoring.""
  },
  {
    ""id"": 102,
    ""label"": ""Strategic Management Services"",
    ""hierarchy"": ""Professional Services > Business Consulting and Services > Strategic Management Services"",
    ""description"": ""This industry includes entities that advise on administrative and management issues, such as financial planning and asset management, records management, office planning, strategic and organizational planning, site selection, new business start-up, and business process improvement. This does not include IT or operations consulting, which are in separate industries.""
  },
  {
    ""id"": 99,
    ""label"": ""Design Services"",
    ""hierarchy"": ""Professional Services > Design Services"",
    ""description"": ""This industry includes entities that provide specialized design services (except architectural, engineering, and computer systems design, which are in separate industries).""
  },
  {
    ""id"": 140,
    ""label"": ""Graphic Design"",
    ""hierarchy"": ""Professional Services > Design Services > Graphic Design"",
    ""description"": ""This industry includes entities that plan, design, and manage the production of visual communication to convey specific messages or concepts, clarify complex information, or project visual identities, such as in the design of printed materials, packaging, advertising, signage systems, and logos. Commercial artists engaged exclusively in generating drawings and illustrations requiring technical accuracy or interpretative skills are included.""
  },
  {
    ""id"": 3256,
    ""label"": ""Regenerative Design"",
    ""hierarchy"": ""Professional Services > Design Services > Regenerative Design"",
    ""description"": ""This industry includes entities that apply specialized design approaches to design buildings, products, and systems that are ecologically restorative and inherently beneficial to the environment. Entities involved in this industry utilize techniques such as biomimicry, permaculture, and green building.""
  },
  {
    ""id"": 3126,
    ""label"": ""Interior Design"",
    ""hierarchy"": ""Professional Services > Design Services > Interior Design"",
    ""description"": ""This industry includes entities that plan, design, and administer projects in interior spaces to meet the physical and aesthetic needs of people using them, taking into consideration building codes, health and safety regulations, traffic patterns and floor planning, mechanical and electrical needs, and interior fittings and furniture.""
  },
  {
    ""id"": 3242,
    ""label"": ""Engineering Services"",
    ""hierarchy"": ""Professional Services > Engineering Services"",
    ""description"": ""This industry includes entities that apply physical laws and principles of engineering in the design, development, and utilization of machines, materials, instruments, structures, processes, and systems. Services include the provision of advice, preparation of feasibility studies, preparation of preliminary and final plans and designs, provision of technical services, inspection, testing and evaluation of engineering projects, and other related services.""
  },
  {
    ""id"": 3248,
    ""label"": ""Robotics Engineering"",
    ""hierarchy"": ""Professional Services > Engineering Services > Robotics Engineering"",
    ""description"": ""This industry includes entities that design autonomous or semi-autonomous robots using knowledge from multiple engineering disciplines, such as computer engineering, mechanical engineering, electrical engineering, bioengineering, control engineering and software engineering.""
  },
  {
    ""id"": 3249,
    ""label"": ""Surveying and Mapping Services"",
    ""hierarchy"": ""Professional Services > Engineering Services > Surveying and Mapping Services"",
    ""description"": ""This industry includes entities that provide surveying and mapping services, such as cartographic, topographic and geophysical surveying and mapping services. Included in this industry are entities involved in locating and measuring subsurface resources, such as oil, gas, and minerals, and conducting surveys for engineering purposes.""
  },
  {
    ""id"": 96,
    ""label"": ""IT Services and IT Consulting"",
    ""hierarchy"": ""Professional Services > IT Services and IT Consulting"",
    ""description"": ""This industry includes entities that: 1. Write, modify, test, and support software to meet the needs of a customer; 2. Plan and design computer systems that integrate computer hardware, software, and communication technologies; 3. Manage and operate clients' computer systems and/or data processing facilities on-site; and/or 4. Provide other professional and technical computer-related advice and services.""
  },
  {
    ""id"": 118,
    ""label"": ""Computer and Network Security"",
    ""hierarchy"": ""Professional Services > IT Services and IT Consulting > Computer and Network Security"",
    ""description"": ""This industry includes entities that provide services and technologies to protect computer systems from unauthorized access, such as theft or damage to hardware, software, or electronic data, including the disruption or misdirection of the services they provide.""
  },
  {
    ""id"": 3244,
    ""label"": ""Digital Accessibility Services"",
    ""hierarchy"": ""Professional Services > IT Services and IT Consulting > Digital Accessibility Services"",
    ""description"": ""This industry includes entities that provide services and technologies that support digital accessibility, such as digital accessibility testing, auditing and consulting services.""
  },
  {
    ""id"": 3102,
    ""label"": ""IT System Custom Software Development"",
    ""hierarchy"": ""Professional Services > IT Services and IT Consulting > IT System Custom Software Development"",
    ""description"": ""This industry includes entities that focus on creating, modifying, testing, and supporting software to meet the needs of a particular customer.""
  },
  {
    ""id"": 3106,
    ""label"": ""IT System Data Services"",
    ""hierarchy"": ""Professional Services > IT Services and IT Consulting > IT System Data Services"",
    ""description"": ""This industry includes entities that provide human expertise for data collection, data annotation, data review, data normalization, and data entry and other manual or semi-automated data services.""
  },
  {
    ""id"": 1855,
    ""label"": ""IT System Design Services"",
    ""hierarchy"": ""Professional Services > IT Services and IT Consulting > IT System Design Services"",
    ""description"": ""This industry includes entities that plan and design computer systems that integrate computer hardware, software, and communication technologies.""
  },
  {
    ""id"": 3104,
    ""label"": ""IT System Installation and Disposal"",
    ""hierarchy"": ""Professional Services > IT Services and IT Consulting > IT System Installation and Disposal"",
    ""description"": ""This industry includes entities that provide IT services related to installing and deploying new IT systems, disaster recovery services, and/or uninstalling, and disposing of no-longer-needed IT systems or components.""
  },
  {
    ""id"": 3103,
    ""label"": ""IT System Operations and Maintenance"",
    ""hierarchy"": ""Professional Services > IT Services and IT Consulting > IT System Operations and Maintenance"",
    ""description"": ""This industry includes entities that manage and/or operate clients' computer systems and/or data processing facilities (on-site or remote).""
  },
  {
    ""id"": 3107,
    ""label"": ""IT System Testing and Evaluation"",
    ""hierarchy"": ""Professional Services > IT Services and IT Consulting > IT System Testing and Evaluation"",
    ""description"": ""This industry includes entities that provide training for and evaluation of IT systems and components.""
  },
  {
    ""id"": 3105,
    ""label"": ""IT System Training and Support"",
    ""hierarchy"": ""Professional Services > IT Services and IT Consulting > IT System Training and Support"",
    ""description"": ""This industry includes entities that provide training and technical support for users and maintainers of IT systems.""
  },
  {
    ""id"": 10,
    ""label"": ""Legal Services"",
    ""hierarchy"": ""Professional Services > Legal Services"",
    ""description"": ""This industry includes entities that offer legal services, such as those offered by offices of lawyers, offices of notaries, title abstract and settlement offices, and paralegal services.""
  },
  {
    ""id"": 120,
    ""label"": ""Alternative Dispute Resolution"",
    ""hierarchy"": ""Professional Services > Legal Services > Alternative Dispute Resolution"",
    ""description"": ""This industry includes entities (except offices of lawyers, attorneys, and paralegals, which are in separate industries) that provide arbitration and conciliation services.""
  },
  {
    ""id"": 9,
    ""label"": ""Law Practice"",
    ""hierarchy"": ""Professional Services > Legal Services > Law Practice"",
    ""description"": ""This industry includes offices of lawyers or attorneys (such as, counselors-at-law) that provide expertise in a range or in specific areas of law, such as criminal law, corporate law, family and estate law, patent law, real estate law, or tax law.""
  },
  {
    ""id"": 136,
    ""label"": ""Photography"",
    ""hierarchy"": ""Professional Services > Photography"",
    ""description"": ""This industry includes entities that provide still, video, or digital photography services. They may specialize in a particular field of photography, such as commercial and industrial photography, portrait photography, and special events photography. Commercial or portrait photography studios are included.""
  },
  {
    ""id"": 70,
    ""label"": ""Research Services"",
    ""hierarchy"": ""Professional Services > Research Services"",
    ""description"": ""This industry includes entities that conduct original investigation undertaken on a systematic basis to gain new knowledge (research) and/or apply research findings or other scientific knowledge to create new or significantly improved products or processes (experimental development). Techniques may include modeling and simulation.""
  },
  {
    ""id"": 12,
    ""label"": ""Biotechnology Research"",
    ""hierarchy"": ""Professional Services > Research Services > Biotechnology Research"",
    ""description"": ""This industry includes entities that conduct biotechnology (except nanobiotechnology) research and experimental development.""
  },
  {
    ""id"": 114,
    ""label"": ""Nanotechnology Research"",
    ""hierarchy"": ""Professional Services > Research Services > Nanotechnology Research"",
    ""description"": ""This industry includes entities that conduct nanotechnology research and experimental development. Research may result in new nanotechnology processes and/or products that may be reproduced, utilized, or implemented by various industries.""
  },
  {
    ""id"": 130,
    ""label"": ""Think Tanks"",
    ""hierarchy"": ""Professional Services > Research Services > Think Tanks"",
    ""description"": ""This industry includes entities that conduct research and analyses in sociology, psychology, economics, and other fields in social sciences and humanities.""
  },
  {
    ""id"": 3243,
    ""label"": ""Services for Renewable Energy"",
    ""hierarchy"": ""Professional Services > Services for Renewable Energy"",
    ""description"": ""This industry includes entities that provide services for renewable energy solutions, such as solar panel installation and renewable energy consulting services.""
  },
  {
    ""id"": 16,
    ""label"": ""Veterinary Services"",
    ""hierarchy"": ""Professional Services > Veterinary Services"",
    ""description"": ""This industry includes entities of licensed veterinary practitioners that practice veterinary medicine, dentistry, or surgery for animals. Entities that provide testing services for licensed veterinary practitioners are included.""
  },
  {
    ""id"": 1757,
    ""label"": ""Real Estate and Equipment Rental Services"",
    ""hierarchy"": ""Real Estate and Equipment Rental Services"",
    ""description"": ""This industry includes entities that rent, lease, or otherwise allow the use of tangible or intangible assets, and entities providing related services such as managing real estate for others, selling, renting and/or buying real estate for others, and appraising real estate.""
  },
  {
    ""id"": 1779,
    ""label"": ""Equipment Rental Services"",
    ""hierarchy"": ""Real Estate and Equipment Rental Services > Equipment Rental Services"",
    ""description"": ""This industry includes entities that provide a wide array of tangible goods, such as automobiles, computers, consumer goods, and industrial machinery and equipment, to customers in return for a periodic rental or lease payment.""
  },
  {
    ""id"": 1798,
    ""label"": ""Commercial and Industrial Equipment Rental"",
    ""hierarchy"": ""Real Estate and Equipment Rental Services > Equipment Rental Services > Commercial and Industrial Equipment Rental"",
    ""description"": ""This industry includes entities that rent or lease commercial-type and industrial-type machinery and equipment -- capital or investment-type equipment that clients use in their business operations.""
  },
  {
    ""id"": 1786,
    ""label"": ""Consumer Goods Rental"",
    ""hierarchy"": ""Real Estate and Equipment Rental Services > Equipment Rental Services > Consumer Goods Rental"",
    ""description"": ""This industry includes entities that rent personal and household-type goods, generally short-term rental although in some instances, the goods may be leased for longer periods of time.""
  },
  {
    ""id"": 44,
    ""label"": ""Real Estate"",
    ""hierarchy"": ""Real Estate and Equipment Rental Services > Real Estate"",
    ""description"": ""This industry includes entities that rent or lease real estate to others; manage, sell, buy, or rent real estate for others; and provide other services related to real estate, such as appraisals. Equity real estate investment trusts (REITs) that lease buildings, dwellings, or other real estate property to others are included. Property development organizations are included in this industry.""
  },
  {
    ""id"": 128,
    ""label"": ""Leasing Non-residential Real Estate"",
    ""hierarchy"": ""Real Estate and Equipment Rental Services > Real Estate > Leasing Non-residential Real Estate"",
    ""description"": ""This industry includes entities that act as lessors of buildings (except mini warehouses and self-storage units, which are in separate industries) that are not used as residences or dwellings.""
  },
  {
    ""id"": 1759,
    ""label"": ""Leasing Residential Real Estate"",
    ""hierarchy"": ""Real Estate and Equipment Rental Services > Real Estate > Leasing Residential Real Estate"",
    ""description"": ""This industry includes entities that act as lessors of residential buildings and dwellings.""
  },
  {
    ""id"": 1770,
    ""label"": ""Real Estate Agents and Brokers"",
    ""hierarchy"": ""Real Estate and Equipment Rental Services > Real Estate > Real Estate Agents and Brokers"",
    ""description"": ""This industry includes entities that primarily act as agents and/or brokers in selling real estate for others; buying real estate for others; and/or renting real estate for others.""
  },
  {
    ""id"": 27,
    ""label"": ""Retail"",
    ""hierarchy"": ""Retail"",
    ""description"": ""This industry includes entities that retail merchandise generally in small quantities to the general public and provide services incidental to the sale of the merchandise.""
  },
  {
    ""id"": 1339,
    ""label"": ""Food and Beverage Retail"",
    ""hierarchy"": ""Retail > Food and Beverage Retail"",
    ""description"": ""This industry includes entities that primarily retail food and/or beverage merchandise from fixed point-of-sale locations and guarantee the proper storage and sanitary conditions required by regulatory authority.""
  },
  {
    ""id"": 22,
    ""label"": ""Retail Groceries"",
    ""hierarchy"": ""Retail > Food and Beverage Retail > Retail Groceries"",
    ""description"": ""This industry includes entities that retail a general line of food, such as canned and frozen foods; fresh fruits and vegetables; and fresh and prepared meats, fish, and poultry. Examples include grocery stores, supermarkets, and delicatessens.""
  },
  {
    ""id"": 1445,
    ""label"": ""Online and Mail Order Retail"",
    ""hierarchy"": ""Retail > Online and Mail Order Retail"",
    ""description"": ""This industry includes entities that create and operate online-only and/or mail-order based marketplaces for the sale of goods. This industry includes entities that retail all types of merchandise using non-store means, such as catalogs, toll free telephone numbers, interactive television, or the Internet.""
  },
  {
    ""id"": 19,
    ""label"": ""Retail Apparel and Fashion"",
    ""hierarchy"": ""Retail > Retail Apparel and Fashion"",
    ""description"": ""This industry includes entities that retail new clothing and clothing accessories from fixed point-of-sale locations.""
  },
  {
    ""id"": 1319,
    ""label"": ""Retail Appliances, Electrical, and Electronic Equipment"",
    ""hierarchy"": ""Retail > Retail Appliances, Electrical, and Electronic Equipment"",
    ""description"": ""This industry includes entities that primarily retail new electronics and appliances, including heating and refrigeration appliances, from point-of-sale locations and may also offer maintenance and repair of the electronic equipment and appliances.""
  },
  {
    ""id"": 3186,
    ""label"": ""Retail Art Dealers"",
    ""hierarchy"": ""Retail > Retail Art Dealers"",
    ""description"": ""This industry includes entities that retail original and limited-edition art works. Included in this industry are entities engaged in displaying works of art for retail sale in art galleries.""
  },
  {
    ""id"": 111,
    ""label"": ""Retail Art Supplies"",
    ""hierarchy"": ""Retail > Retail Art Supplies"",
    ""description"": ""This industry includes entities that retail art materials and supplies.""
  },
  {
    ""id"": 1409,
    ""label"": ""Retail Books and Printed News"",
    ""hierarchy"": ""Retail > Retail Books and Printed News"",
    ""description"": ""This industry includes entities that primarily retail new books, newspapers, magazines, and other periodicals.""
  },
  {
    ""id"": 1324,
    ""label"": ""Retail Building Materials and Garden Equipment"",
    ""hierarchy"": ""Retail > Retail Building Materials and Garden Equipment"",
    ""description"": ""This industry includes entities that primarily retail new building materials and garden equipment and supplies, including hardware and plumbing fixtures, from fixed point-of-sale locations.""
  },
  {
    ""id"": 1423,
    ""label"": ""Retail Florists"",
    ""hierarchy"": ""Retail > Retail Florists"",
    ""description"": ""This industry includes entities that primarily retail cut flowers, floral arrangements, and potted plants purchased from others.""
  },
  {
    ""id"": 1309,
    ""label"": ""Retail Furniture and Home Furnishings"",
    ""hierarchy"": ""Retail > Retail Furniture and Home Furnishings"",
    ""description"": ""This industry includes entities that primarily retail new furniture and home furnishings from fixed point-of-sale locations and many offer interior decorating services in addition to the sale of products.""
  },
  {
    ""id"": 1370,
    ""label"": ""Retail Gasoline"",
    ""hierarchy"": ""Retail > Retail Gasoline"",
    ""description"": ""This industry includes entities that primarily retail automotive fuels (e.g., gasoline, diesel fuel, gasohol, alternative fuels) and automotive oils or retail these products in combination with convenience store items.""
  },
  {
    ""id"": 1359,
    ""label"": ""Retail Health and Personal Care Products"",
    ""hierarchy"": ""Retail > Retail Health and Personal Care Products"",
    ""description"": ""This industry includes entities that primarily retail health and personal care merchandise from fixed point-of-sale locations and may offer services related to retailing, advising customers, and/or fitting the product sold to the customer's needs.""
  },
  {
    ""id"": 3250,
    ""label"": ""Retail Pharmacies"",
    ""hierarchy"": ""Retail > Retail Health and Personal Care Products > Retail Pharmacies"",
    ""description"": ""This industry includes entities that retail prescription or nonprescription drugs and medicines.""
  },
  {
    ""id"": 143,
    ""label"": ""Retail Luxury Goods and Jewelry"",
    ""hierarchy"": ""Retail > Retail Luxury Goods and Jewelry"",
    ""description"": ""This industry includes entities that retail one or more of the following items: 1. New jewelry (except costume jewelry); 2. New sterling and plated silverware; and 3. New watches and clocks. Also included are entities retailing these new products in combination with lapidary work and/or repair services.""
  },
  {
    ""id"": 1292,
    ""label"": ""Retail Motor Vehicles"",
    ""hierarchy"": ""Retail > Retail Motor Vehicles"",
    ""description"": ""This industry includes entities that primarily retail motor vehicles and parts from fixed point-of-sale locations and also provide repair and maintenance services for vehicles.""
  },
  {
    ""id"": 1407,
    ""label"": ""Retail Musical Instruments"",
    ""hierarchy"": ""Retail > Retail Musical Instruments"",
    ""description"": ""This industry includes entities that primarily retail new musical instruments, sheet music, and related supplies; or retailing these new products in combination with services like musical instrument repair, rental, or music instruction.""
  },
  {
    ""id"": 138,
    ""label"": ""Retail Office Equipment"",
    ""hierarchy"": ""Retail > Retail Office Equipment"",
    ""description"": ""This industry includes entities that retail office equipment, such as printers, copiers, and other general office machinery.""
  },
  {
    ""id"": 1424,
    ""label"": ""Retail Office Supplies and Gifts"",
    ""hierarchy"": ""Retail > Retail Office Supplies and Gifts"",
    ""description"": ""This industry includes entities that primarily retail new office supplies, stationery, gifts, novelty merchandise, and souvenirs.""
  },
  {
    ""id"": 1431,
    ""label"": ""Retail Recyclable Materials & Used Merchandise"",
    ""hierarchy"": ""Retail > Retail Recyclable Materials & Used Merchandise"",
    ""description"": ""This industry includes entities that primarily retail used merchandise, antiques, and secondhand goods (except motor vehicles, such as automobiles, RVs, motorcycles, and boats; motor vehicle parts; tires; and mobile homes, which are in separate industries).""
  },
  {
    ""id"": 1594,
    ""label"": ""Technology, Information and Media"",
    ""hierarchy"": ""Technology, Information and Media"",
    ""description"": ""This industry includes entities that produce technology products, such as software and data analytics, and provide the means to transmit or distribute these products. Also included are motion picture and sound recording; traditional broadcasting and broadcasting exclusively over the Internet; telecommunications; data processing; and Web search portals and information services.""
  },
  {
    ""id"": 3133,
    ""label"": ""Media & Telecommunications"",
    ""hierarchy"": ""Technology, Information and Media > Media and Telecommunications"",
    ""description"": ""This industry includes entities that provide telecommunications and related services and media production and distribution, including broadcast media, movies, sound recordings, and animation.""
  },
  {
    ""id"": 82,
    ""label"": ""Book and Periodical Publishing"",
    ""hierarchy"": ""Technology, Information and Media > Media and Telecommunications > Book and Periodical Publishing"",
    ""description"": ""This industry includes entities that publish newspapers, magazines, other periodicals, and books, as well as directories and mailing lists.""
  },
  {
    ""id"": 1602,
    ""label"": ""Book Publishing"",
    ""hierarchy"": ""Technology, Information and Media > Media and Telecommunications > Book and Periodical Publishing > Book Publishing"",
    ""description"": ""This industry includes entities known as book publishers that carry out design, editing, and marketing activities necessary for producing and distributing books, in print, electronic, or audio form.""
  },
  {
    ""id"": 81,
    ""label"": ""Newspaper Publishing"",
    ""hierarchy"": ""Technology, Information and Media > Media and Telecommunications > Book and Periodical Publishing > Newspaper Publishing"",
    ""description"": ""This industry includes entities known as newspaper publishers. Entities in this industry produce and distribute newspapers (such as, gather news; write news columns, feature stories, and editorials; and sell and prepare advertisements). These entities may publish newspapers in print or electronic form.""
  },
  {
    ""id"": 1600,
    ""label"": ""Periodical Publishing"",
    ""hierarchy"": ""Technology, Information and Media > Media and Telecommunications > Book and Periodical Publishing > Periodical Publishing"",
    ""description"": ""This industry includes entities known either as magazine or periodical publishers that carry out the operations necessary for producing and distributing magazines and other periodicals, such as gathering, writing, and editing articles, and selling and preparing advertisements and may publish magazines and other periodicals in print or electronic form.""
  },
  {
    ""id"": 36,
    ""label"": ""Broadcast Media Production and Distribution"",
    ""hierarchy"": ""Technology, Information and Media > Media and Telecommunications > Broadcast Media Production and Distribution"",
    ""description"": ""This industry includes entities that create or license radio or television content as well as distribute or broadcast it.""
  },
  {
    ""id"": 1641,
    ""label"": ""Cable and Satellite Programming"",
    ""hierarchy"": ""Technology, Information and Media > Media and Telecommunications > Broadcast Media Production and Distribution > Cable and Satellite Programming"",
    ""description"": ""This industry includes entities that operate studios and facilities for the broadcasting of programs on a subscription or fee basis which are usually delivered to a third party, such as cable systems or direct-to-home satellite systems, for transmission to viewers.""
  },
  {
    ""id"": 1633,
    ""label"": ""Radio and Television Broadcasting"",
    ""hierarchy"": ""Technology, Information and Media > Media and Telecommunications > Broadcast Media Production and Distribution > Radio and Television Broadcasting"",
    ""description"": ""This industry includes entities that operate broadcast studios and facilities for over-the-air or satellite delivery of radio and television programs and often generate revenues from the sale of air time to advertisers, from donations and subsidies, or from the sale of programs.""
  },
  {
    ""id"": 35,
    ""label"": ""Movies, Videos and Sound"",
    ""hierarchy"": ""Technology, Information and Media > Media and Telecommunications > Movies, Videos and Sound"",
    ""description"": ""This industry includes entities that primarily produce and distribute movies, videos and sound recordings.""
  },
  {
    ""id"": 127,
    ""label"": ""Animation and Post-production"",
    ""hierarchy"": ""Technology, Information and Media > Media and Telecommunications > Movies, Videos and Sound > Animation and Post-production"",
    ""description"": ""This industry includes entities that provide specialized motion picture or video postproduction services, such as editing, film/tape transfers, subtitling, credits, closed captioning, and animation and special effects.""
  },
  {
    ""id"": 126,
    ""label"": ""Media Production"",
    ""hierarchy"": ""Technology, Information and Media > Media and Telecommunications > Movies, Videos and Sound > Media Production"",
    ""description"": ""This industry includes entities that produce multimedia content. Entities in this industry do not distribute or broadcast this content themselves.""
  },
  {
    ""id"": 1611,
    ""label"": ""Movies and Sound Recording"",
    ""hierarchy"": ""Technology, Information and Media > Media and Telecommunications > Movies, Videos and Sound > Movies and Sound Recording"",
    ""description"": ""This industry includes entities that primarily produce and distribute movies and sound recordings.""
  },
  {
    ""id"": 1623,
    ""label"": ""Sound Recording"",
    ""hierarchy"": ""Technology, Information and Media > Media and Telecommunications > Movies, Videos and Sound > Movies and Sound Recording > Sound Recording"",
    ""description"": ""This industry includes entities that primarily produce and distribute musical recordings, publish music, or provide sound recording and related services.""
  },
  {
    ""id"": 1625,
    ""label"": ""Sheet Music Publishing"",
    ""hierarchy"": ""Technology, Information and Media > Media and Telecommunications > Movies, Videos and Sound > Sheet Music Publishing"",
    ""description"": ""This industry includes entities that primarily acquire and register copyrights for musical compositions in accordance with law and promoting and authorizing the use of these compositions in recordings, radio, television, motion pictures, live performances, print, or other media.""
  },
  {
    ""id"": 8,
    ""label"": ""Telecommunications"",
    ""hierarchy"": ""Technology, Information and Media > Media and Telecommunications > Telecommunications"",
    ""description"": ""This industry includes entities that provide telecommunications and related services (e.g., telephony, including Voice over Internet Protocol (VoIP); cable and satellite television distribution services; Internet access; and telecommunications reselling services). They operate and/or provide access to facilities for the transmission of voice, data, text, sound, and video.""
  },
  {
    ""id"": 1649,
    ""label"": ""Satellite Telecommunications"",
    ""hierarchy"": ""Technology, Information and Media > Media and Telecommunications > Telecommunications > Satellite Telecommunications"",
    ""description"": ""This industry includes entities that provide telecommunications services to other entities in the telecommunications and broadcasting industries by forwarding and receiving communications signals via a system of satellites or reselling satellite telecommunications.""
  },
  {
    ""id"": 1644,
    ""label"": ""Telecommunications Carriers"",
    ""hierarchy"": ""Technology, Information and Media > Media and Telecommunications > Telecommunications > Telecommunications Carriers"",
    ""description"": ""This industry includes entities that operate, maintain, and/or provide access to switching and transmission facilities and infrastructure that they own and/or lease for the transmission of voice, data, text, sound, and video using wired and wireless telecommunications networks.""
  },
  {
    ""id"": 119,
    ""label"": ""Wireless Services"",
    ""hierarchy"": ""Technology, Information and Media > Media and Telecommunications > Telecommunications > Wireless Services"",
    ""description"": ""This industry includes entities that operate and maintain switching and transmission facilities to provide communications via the airwaves, such as cellular phone services, paging services, wireless Internet access, and wireless video services.""
  },
  {
    ""id"": 6,
    ""label"": ""Technology, Information and Internet"",
    ""hierarchy"": ""Technology, Information and Media > Technology, Information and Internet"",
    ""description"": ""This industry includes entities that publish computer software, provide data infrastructure and analytics, provide web-based platforms (including marketplace platforms and social media platforms, and media streaming services), and provide information services, including internet publishing and libraries.""
  },
  {
    ""id"": 2458,
    ""label"": ""Data Infrastructure and Analytics"",
    ""hierarchy"": ""Technology, Information and Media > Technology, Information and Internet > Data Infrastructure and Analytics"",
    ""description"": ""This industry includes entities that provide infrastructure for hosting including web or application hosting, streaming services, and general time-share mainframe facilities to clients, or they provide data processing, data entry, or data analysis services.""
  },
  {
    ""id"": 3134,
    ""label"": ""Blockchain Services"",
    ""hierarchy"": ""Technology, Information and Media > Technology, Information and Internet > Data Infrastructure and Analytics > Blockchain Services"",
    ""description"": ""This industry includes entities that provide infrastructure for management of decentralized digital assets, such as cryptocurrency and non-fungible tokens (NFTs). Cryptocurrency trading platforms and blockchain hosting platforms are included in this industry.""
  },
  {
    ""id"": 3128,
    ""label"": ""Business Intelligence Platforms"",
    ""hierarchy"": ""Technology, Information and Media > Technology, Information and Internet > Data Infrastructure and Analytics > Business Intelligence Platforms"",
    ""description"": ""This industry includes entities that provide content, data, services, and/or computer hardware for gathering or distributing information specifically about markets and business activities.""
  },
  {
    ""id"": 3252,
    ""label"": ""Climate Data and Analytics"",
    ""hierarchy"": ""Technology, Information and Media > Technology, Information and Internet > Data Infrastructure and Analytics > Climate Data and Analytics"",
    ""description"": ""This industry includes entities that collect, analyze, and interpret data related to the Earth's climate. It includes data from sources such as satellites, weather stations, and ocean buoys.""
  },
  {
    ""id"": 84,
    ""label"": ""Information Services"",
    ""hierarchy"": ""Technology, Information and Media > Technology, Information and Internet > Information Services"",
    ""description"": ""This industry includes entities that supply information, store and provide access to information, search and retrieve information, or operate Web sites that use search engines to allow for Internet search. Examples are libraries, archives, and Web search portals.""
  },
  {
    ""id"": 3132,
    ""label"": ""Internet Publishing"",
    ""hierarchy"": ""Technology, Information and Media > Technology, Information and Internet > Information Services > Internet Publishing"",
    ""description"": ""This industry includes entities that publish and/or broadcast content on the Internet exclusively. They do not provide traditional (non-Internet) versions of the content they publish or broadcast.""
  },
  {
    ""id"": 3129,
    ""label"": ""Business Content"",
    ""hierarchy"": ""Technology, Information and Media > Technology, Information and Internet > Information Services > Internet Publishing > Business Content"",
    ""description"": ""This industry includes entities that provide news and content about markets and business activities.""
  },
  {
    ""id"": 113,
    ""label"": ""Online Audio and Video Media"",
    ""hierarchy"": ""Technology, Information and Media > Technology, Information and Internet > Information Services > Internet Publishing > Online Audio and Video Media"",
    ""description"": ""This industry includes entities that publish and/or broadcast content on the Internet exclusively. These entities publish in audio and video content primarily, and do not publish news, business content, blogs or vlogs.""
  },
  {
    ""id"": 3124,
    ""label"": ""Internet News"",
    ""hierarchy"": ""Technology, Information and Media > Technology, Information and Internet > Information Services > Internet Publishing > Online Audio and Video Media > Internet News"",
    ""description"": ""This industry includes entities that publish and/or broadcast news content on the Internet exclusively or operate Web sites that use a search engine to generate and maintain extensive databases of news in an easily searchable format, and do not provide traditional (non-Internet) versions of the content that they publish or broadcast.""
  },
  {
    ""id"": 85,
    ""label"": ""Libraries"",
    ""hierarchy"": ""Technology, Information and Media > Technology, Information and Internet > Information Services > Libraries"",
    ""description"": ""This industry includes entities that provide library or archive services. They maintain collections of documents (e.g., books, journals, newspapers, and music) and archival material of historical interest for informational, research, educational, or recreational use. All or portions may be accessible electronically.""
  },
  {
    ""id"": 3125,
    ""label"": ""Blogs"",
    ""hierarchy"": ""Technology, Information and Media > Technology, Information and Internet > Information Services >Internet Publishing > Blogs"",
    ""description"": ""This industry includes entities that produce content for the internet: textual or video blogs.""
  },
  {
    ""id"": 1285,
    ""label"": ""Internet Marketplace Platforms"",
    ""hierarchy"": ""Technology, Information and Media > Technology, Information and Internet > Internet Marketplace Platforms"",
    ""description"": ""This industry includes entities that provide a web-based platform for the buying and selling of goods owned by others, or as a marketplace that creates a trading opportunity between two entities or parties (e.g., matching platforms), generally on a fee or commission basis.""
  },
  {
    ""id"": 3127,
    ""label"": ""Social Networking Platforms"",
    ""hierarchy"": ""Technology, Information and Media > Technology, Information and Internet > Social Networking Platforms"",
    ""description"": ""This industry includes entities that provide services and infrastructure for social networking, primarily over the internet.""
  },
  {
    ""id"": 4,
    ""label"": ""Software Development"",
    ""hierarchy"": ""Technology, Information and Media > Technology, Information and Internet > Software Development"",
    ""description"": ""This industry includes entities that publish computer software and carry out operations necessary for production and distribution, such as design, documentation, installation, and support services. They may design, develop, and publish, or publish only; they may publish and distribute remotely through subscriptions and downloads.""
  },
  {
    ""id"": 109,
    ""label"": ""Computer Games"",
    ""hierarchy"": ""Technology, Information and Media > Technology, Information and Internet > Software Development > Computer Games"",
    ""description"": ""This industry includes entities that produce user-facing software for gaming on different platforms.""
  },
  {
    ""id"": 3131,
    ""label"": ""Mobile Gaming Apps"",
    ""hierarchy"": ""Technology, Information and Media > Technology, Information and Internet > Software Development > Computer Games > Mobile Gaming Apps"",
    ""description"": ""This industry includes entities that produce user-facing software for gaming on mobile platforms.""
  },
  {
    ""id"": 5,
    ""label"": ""Computer Networking Products"",
    ""hierarchy"": ""Technology, Information and Media > Technology, Information and Internet > Software Development > Computer Networking Products"",
    ""description"": ""This industry includes entities that produce software that manages or runs on collections of connected computers.""
  },
  {
    ""id"": 3130,
    ""label"": ""Data Security Software Products"",
    ""hierarchy"": ""Technology, Information and Media > Technology, Information and Internet > Software Development > Data Security Software Products"",
    ""description"": ""This industry includes entities that produce software to ensure security of data and computing systems.""
  },
  {
    ""id"": 3101,
    ""label"": ""Desktop Computing Software Products"",
    ""hierarchy"": ""Technology, Information and Media > Technology, Information and Internet > Software Development > Desktop Computing Software Products"",
    ""description"": ""This industry includes entities that produce software which runs on desktop or laptop computers.""
  },
  {
    ""id"": 3099,
    ""label"": ""Embedded Software Products"",
    ""hierarchy"": ""Technology, Information and Media > Technology, Information and Internet > Software Development > Embedded Software Products"",
    ""description"": ""This industry includes entities that produce software (or \""firmware\"") for machines or devices that are not usually thought of as computers, ex: routers, refrigerators, display systems, washing machines, etc. such as, software for the internet of things but do not produce these devices.""
  },
  {
    ""id"": 3100,
    ""label"": ""Mobile Computing Software Products"",
    ""hierarchy"": ""Technology, Information and Media > Technology, Information and Internet > Software Development > Mobile Computing Software Products"",
    ""description"": ""This industry includes entities that produce software which runs on mobile computing devices such as smartphones and tablet computers.""
  },
  {
    ""id"": 116,
    ""label"": ""Transportation, Logistics, Supply Chain and Storage"",
    ""hierarchy"": ""Transportation, Logistics, Supply Chain and Storage"",
    ""description"": ""This industry includes entities that store and warehouse goods, transport passengers and cargo, provide scenic and sightseeing transportation, and provide support activities related to modes of transportation.""
  },
  {
    ""id"": 94,
    ""label"": ""Airlines and Aviation"",
    ""hierarchy"": ""Transportation, Logistics, Supply Chain and Storage > Airlines and Aviation"",
    ""description"": ""This industry includes entities that provide air transportation of passengers and/or cargo using aircraft, such as airplanes and helicopters. Included are scheduled air transportation and nonscheduled, such as chartered air transportation of passengers, cargo, or specialty flying services.""
  },
  {
    ""id"": 87,
    ""label"": ""Freight and Package Transportation"",
    ""hierarchy"": ""Transportation, Logistics, Supply Chain and Storage > Freight and Package Transportation"",
    ""description"": ""This industry includes entities that primarily provide a variety of transportation services for freight, packages, and mail.""
  },
  {
    ""id"": 1495,
    ""label"": ""Ground Passenger Transportation"",
    ""hierarchy"": ""Transportation, Logistics, Supply Chain and Storage > Ground Passenger Transportation"",
    ""description"": ""This industry includes entities that primarily provide a variety of ground passenger transportation services, such as urban transit systems; chartered bus, school bus, and interurban bus transportation; and taxis.""
  },
  {
    ""id"": 1504,
    ""label"": ""Interurban and Rural Bus Services"",
    ""hierarchy"": ""Transportation, Logistics, Supply Chain and Storage > Ground Passenger Transportation > Interurban and Rural Bus Services"",
    ""description"": ""This industry includes entities that primarily provide bus passenger transportation over regular routes and on regular schedules, principally outside a single metropolitan area.""
  },
  {
    ""id"": 1512,
    ""label"": ""School and Employee Bus Services"",
    ""hierarchy"": ""Transportation, Logistics, Supply Chain and Storage > Ground Passenger Transportation > School and Employee Bus Services"",
    ""description"": ""This industry includes entities that primarily provide buses and other motor vehicles to transport pupils to and from school or employees to and from work.""
  },
  {
    ""id"": 1517,
    ""label"": ""Shuttles and Special Needs Transportation Services"",
    ""hierarchy"": ""Transportation, Logistics, Supply Chain and Storage > Ground Passenger Transportation > Shuttles and Special Needs Transportation Services"",
    ""description"": ""This industry includes entities that primarily provide other transit and ground passenger transportation (except urban transit systems, interurban and rural bus transportation, taxi services, school and employee bus transportation, charter bus services, and limousine services (except shuttle services), which are in separate industries), including shuttle services (except employee bus, which is in a separate industry) and special needs transportation services.""
  },
  {
    ""id"": 1532,
    ""label"": ""Sightseeing Transportation"",
    ""hierarchy"": ""Transportation, Logistics, Supply Chain and Storage > Ground Passenger Transportation > Sightseeing Transportation"",
    ""description"": ""This industry includes entities that primarily use transportation equipment to provide recreation and entertainment.""
  },
  {
    ""id"": 1505,
    ""label"": ""Taxi and Limousine Services"",
    ""hierarchy"": ""Transportation, Logistics, Supply Chain and Storage > Ground Passenger Transportation > Taxi and Limousine Services"",
    ""description"": ""This industry includes entities that primarily provide passenger transportation by automobile or van or providing an array of specialty and luxury passenger transportation services via limousine or luxury sedan generally on a reserved basis, and do not operate over regular routes and on regular schedules.""
  },
  {
    ""id"": 1497,
    ""label"": ""Urban Transit Services"",
    ""hierarchy"": ""Transportation, Logistics, Supply Chain and Storage > Ground Passenger Transportation > Urban Transit Services"",
    ""description"": ""This industry includes entities that primarily operate local and suburban passenger transit systems over regular routes and on regular schedules within a metropolitan area.""
  },
  {
    ""id"": 95,
    ""label"": ""Maritime Transportation"",
    ""hierarchy"": ""Transportation, Logistics, Supply Chain and Storage > Maritime Transportation"",
    ""description"": ""This industry includes entities that transport passengers and cargo using watercraft, such as ships, barges, and boats. This includes deep sea, coastal, and inland water transportation.""
  },
  {
    ""id"": 1520,
    ""label"": ""Pipeline Transportation"",
    ""hierarchy"": ""Transportation, Logistics, Supply Chain and Storage > Pipeline Transportation"",
    ""description"": ""This industry includes entities that primarily use transmission pipelines to transport products, such as crude oil, natural gas, refined petroleum products, and slurry, which may include the storage of natural gas.""
  },
  {
    ""id"": 1573,
    ""label"": ""Postal Services"",
    ""hierarchy"": ""Transportation, Logistics, Supply Chain and Storage > Postal Services"",
    ""description"": ""This industry includes government entities that provide mail services under a universal service obligation, including the carriage of letters, printed matter, or mailable packages, including acceptance, collection, processing, and delivery.""
  },
  {
    ""id"": 1481,
    ""label"": ""Rail Transportation"",
    ""hierarchy"": ""Transportation, Logistics, Supply Chain and Storage > Rail Transportation"",
    ""description"": ""This industry includes entities that primarily provide rail transportation of passengers and/or cargo using railroad rolling stock that operate on networks, with physical facilities, labor force, and equipment spread over an extensive geographic area, or operate over a short distance on a local rail line.""
  },
  {
    ""id"": 92,
    ""label"": ""Truck Transportation"",
    ""hierarchy"": ""Transportation, Logistics, Supply Chain and Storage > Truck Transportation"",
    ""description"": ""This industry includes entities that provide over-the-road transportation of cargo using motor vehicles, such as trucks and tractor trailers. This includes general freight trucking (such as palletized commodities transported in a container or van trailer) and specialized freight trucking (such as, transportation of cargo that, because of size, weight, or shape, requires specialized transportation equipment).""
  },
  {
    ""id"": 93,
    ""label"": ""Warehousing and Storage"",
    ""hierarchy"": ""Transportation, Logistics, Supply Chain and Storage > Warehousing and Storage"",
    ""description"": ""This industry includes entities that operate warehouse and storage facilities for general merchandise, refrigerated goods, and other warehouse products. They take responsibility for keeping goods secure and do not sell the goods they handle but may provide services related to the distribution of goods, such as labeling, inventory control, and light assembly.""
  },
  {
    ""id"": 59,
    ""label"": ""Utilities"",
    ""hierarchy"": ""Utilities"",
    ""description"": ""This industry includes entities that provide electric power, natural gas, steam supply, water supply, and sewage removal. Electric power includes generation, transmission, and distribution; natural gas includes distribution; steam supply includes provision and/or distribution; water supply includes treatment and distribution; and sewage removal includes collection, treatment, and disposal through sewer systems and treatment facilities.""
  },
  {
    ""id"": 383,
    ""label"": ""Electric Power Generation"",
    ""hierarchy"": ""Utilities > Electric Power Generation"",
    ""description"": ""This industry includes entities that operate electric power generation facilities. These facilities convert other forms of energy, such as waterpower (such as, hydroelectric), fossil fuels, nuclear power, and solar power, into electrical energy provided to transmission or electric power distribution systems.""
  },
  {
    ""id"": 385,
    ""label"": ""Fossil Fuel Electric Power Generation"",
    ""hierarchy"": ""Utilities > Electric Power Generation > Fossil Fuel Electric Power Generation"",
    ""description"": ""This industry includes entities that operate fossil-fuel-powered electric power generation facilities. These facilities use fossil fuels (coal, oil, or gas) in internal combustion or combustion-turbine conventional steam processes to produce electric energy provided to transmission or electric power distribution systems.""
  },
  {
    ""id"": 386,
    ""label"": ""Nuclear Electric Power Generation"",
    ""hierarchy"": ""Utilities > Electric Power Generation > Nuclear Electric Power Generation"",
    ""description"": ""This industry includes entities that operate nuclear electric power generation facilities. These facilities use nuclear power to produce electric energy provided to transmission or electric power distribution systems.""
  },
  {
    ""id"": 3240,
    ""label"": ""Renewable Energy Power Generation"",
    ""hierarchy"": ""Utilities > Electric Power Generation > Renewable Energy Power Generation"",
    ""description"": ""This industry includes entities that operate electric power generation facilities that use renewable energy resources.""
  },
  {
    ""id"": 390,
    ""label"": ""Biomass Electric Power Generation"",
    ""hierarchy"": ""Utilities > Electric Power Generation > Renewable Energy Power Generation > Biomass Electric Power Generation"",
    ""description"": ""This industry includes entities that operate biomass electric power generation facilities. These facilities use biomass (wood, waste, alcohol fuels) to produce electric energy provided to transmission or electric power distribution systems.""
  },
  {
    ""id"": 389,
    ""label"": ""Geothermal Electric Power Generation"",
    ""hierarchy"": ""Utilities > Electric Power Generation > Renewable Energy Power Generation > Geothermal Electric Power Generation"",
    ""description"": ""This industry includes entities that operate geothermal electric power generation facilities. These facilities use heat derived from the Earth to produce electric energy provided to transmission or electric power distribution systems.""
  },
  {
    ""id"": 384,
    ""label"": ""Hydroelectric Power Generation"",
    ""hierarchy"": ""Utilities > Electric Power Generation > Renewable Energy Power Generation > Hydroelectric Power Generation"",
    ""description"": ""This industry includes entities that operate hydroelectric power generation facilities. These facilities use waterpower to drive a turbine and produce electric energy provided to transmission or electric power distribution systems.""
  },
  {
    ""id"": 387,
    ""label"": ""Solar Electric Power Generation"",
    ""hierarchy"": ""Utilities > Electric Power Generation > Renewable Energy Power Generation > Solar Electric Power Generation"",
    ""description"": ""This industry includes entities that operate solar electric power generation facilities. These facilities use energy from the sun to produce electric energy.""
  },
  {
    ""id"": 2489,
    ""label"": ""Wind Electric Power Generation"",
    ""hierarchy"": ""Utilities > Electric Power Generation > Renewable Energy Power Generation > Wind Electric Power Generation"",
    ""description"": ""This industry includes entities that operate wind electric power generation facilities to drive turbines and produce electric energy for electric power transmission systems or for electric power distribution systems.""
  },
  {
    ""id"": 382,
    ""label"": ""Electric Power Transmission, Control, and Distribution"",
    ""hierarchy"": ""Utilities > Electric Power Transmission, Control, and Distribution"",
    ""description"": ""This industry includes entities that operate electric power transmission systems; control (such as, regulate voltages) the transmission of electricity; and/or distribute electricity to distribution centers, other electric utilities, or final consumers.""
  },
  {
    ""id"": 397,
    ""label"": ""Natural Gas Distribution"",
    ""hierarchy"": ""Utilities > Natural Gas Distribution"",
    ""description"": ""This industry includes entities that: 1. Operate gas distribution systems (e.g., mains, meters); 2. Buy gas from the well and sell it to a distribution system (such as gas marketers); 3. Arrange the sale of gas over gas distribution systems operated by others (such as gas brokers or agents); and 4. Transmit and distribute gas to final consumers.""
  },
  {
    ""id"": 398,
    ""label"": ""Water, Waste, Steam, and Air Conditioning Services"",
    ""hierarchy"": ""Utilities > Water, Waste, Steam, and Air Conditioning Services"",
    ""description"": ""This industry includes entities that: 1. Operate water treatment plants and/or water supply systems; 2. Operate sewer systems or sewage treatment facilities; or 3. Provide steam, heated air, or cooled air.""
  },
  {
    ""id"": 404,
    ""label"": ""Steam and Air-Conditioning Supply"",
    ""hierarchy"": ""Utilities > Water, Waste, Steam, and Air Conditioning Services > Steam and Air-Conditioning Supply"",
    ""description"": ""This industry includes entities that provide steam, heated air, or cooled air. The steam distribution may be through mains.""
  },
  {
    ""id"": 1981,
    ""label"": ""Waste Collection"",
    ""hierarchy"": ""Utilities > Water, Waste, Steam, and Air Conditioning Services > Waste Collection"",
    ""description"": ""This industry includes entities that collect and/or haul hazardous waste, nonhazardous waste, and/or recyclable materials within a local area and/or operate hazardous or nonhazardous waste transfer stations and may be responsible for the identification, treatment, packaging, and labeling of waste for the purposes of transport.""
  },
  {
    ""id"": 1986,
    ""label"": ""Waste Treatment and Disposal"",
    ""hierarchy"": ""Utilities > Water, Waste, Steam, and Air Conditioning Services > Waste Treatment and Disposal"",
    ""description"": ""This industry includes entities that operate waste treatment or disposal facilities (except sewer systems or sewage treatment facilities, which are in a separate industry) or offer the combined activity of collecting and/or hauling of waste materials within a local area and operating waste treatment or disposal facilities. Waste combustors or incinerators, solid waste landfills, and compost dumps are included in this industry.""
  },
  {
    ""id"": 400,
    ""label"": ""Water Supply and Irrigation Systems"",
    ""hierarchy"": ""Utilities > Water, Waste, Steam, and Air Conditioning Services > Water Supply and Irrigation Systems"",
    ""description"": ""This industry includes entities that operate treatment plants and/or water supply systems. This may include pumping stations, aqueducts, and/or distribution mains, for water used for drinking, irrigation, or other uses.""
  },
  {
    ""id"": 133,
    ""label"": ""Wholesale"",
    ""hierarchy"": ""Wholesale"",
    ""description"": ""This industry includes entities that distribute wholesale merchandise, generally without transformation, and render services incidental to the sale of merchandise. Merchandise includes the outputs of agriculture, mining, manufacturing, and certain information industries, such as publishing.""
  },
  {
    ""id"": 1267,
    ""label"": ""Wholesale Alcoholic Beverages"",
    ""hierarchy"": ""Wholesale > Wholesale Alcoholic Beverages"",
    ""description"": ""This industry includes entities that distribute wholesale beer, ale, wine, and/or distilled alcoholic beverages.""
  },
  {
    ""id"": 1222,
    ""label"": ""Wholesale Apparel and Sewing Supplies"",
    ""hierarchy"": ""Wholesale > Wholesale Apparel and Sewing Supplies"",
    ""description"": ""This industry includes entities that distribute wholesale piece goods, notions, and other dry goods; men's and boys' clothing and furnishings; women's, children's, and infants' clothing and accessories; and footwear.""
  },
  {
    ""id"": 1171,
    ""label"": ""Wholesale Appliances, Electrical, and Electronics"",
    ""hierarchy"": ""Wholesale > Wholesale Appliances, Electrical, and Electronics"",
    ""description"": ""This industry includes entities that distribute wholesale electrical apparatus and equipment, wiring supplies, and related equipment; household appliances, electric housewares, and consumer electronics; and other electronic parts and equipment.""
  },
  {
    ""id"": 49,
    ""label"": ""Wholesale Building Materials"",
    ""hierarchy"": ""Wholesale > Wholesale Building Materials"",
    ""description"": ""This industry includes entities that distribute wholesale building materials, such as lumber, plywood, millwork, and wood panels; brick, stone, and related construction materials; roofing, siding, and insulation materials; and other construction materials, including manufactured homes (such as, mobile homes) and/or prefabricated buildings.""
  },
  {
    ""id"": 1257,
    ""label"": ""Wholesale Chemical and Allied Products"",
    ""hierarchy"": ""Wholesale > Wholesale Chemical and Allied Products"",
    ""description"": ""This industry includes entities that distribute wholesale chemicals, plastics materials and basic forms and shapes, and allied products.""
  },
  {
    ""id"": 1157,
    ""label"": ""Wholesale Computer Equipment"",
    ""hierarchy"": ""Wholesale > Wholesale Computer Equipment"",
    ""description"": ""This industry includes entities that distribute wholesale computers and computer equipment.""
  },
  {
    ""id"": 1221,
    ""label"": ""Wholesale Drugs and Sundries"",
    ""hierarchy"": ""Wholesale > Wholesale Drugs and Sundries"",
    ""description"": ""This industry includes entities that distribute wholesale biological and medical products; botanical drugs and herbs; and pharmaceutical products intended for internal and/or external consumption in such forms as ampoules, tablets, capsules, vials, ointments, powders, solutions, and suspensions.""
  },
  {
    ""id"": 1231,
    ""label"": ""Wholesale Food and Beverage"",
    ""hierarchy"": ""Wholesale > Wholesale Food and Beverage"",
    ""description"": ""This industry includes entities that distribute wholesale: 1. General line of groceries; 2. Packaged frozen food; 3. Dairy products; 4. Poultry and poultry products; 5. Confectioneries; 6. Fish and seafood; 7. Meats and meat products; 8. Fresh fruits and vegetables; and 9. Other grocery and related products.""
  },
  {
    ""id"": 1230,
    ""label"": ""Wholesale Footwear"",
    ""hierarchy"": ""Wholesale > Wholesale Footwear"",
    ""description"": ""This industry includes entities that distribute wholesale footwear (including athletic footwear) leather, rubber, and other materials.""
  },
  {
    ""id"": 1137,
    ""label"": ""Wholesale Furniture and Home Furnishings"",
    ""hierarchy"": ""Wholesale > Wholesale Furniture and Home Furnishings"",
    ""description"": ""This industry includes entities that distribute wholesale furniture (except hospital beds, medical furniture, and drafting tables), home furnishings, and/or housewares.""
  },
  {
    ""id"": 1178,
    ""label"": ""Wholesale Hardware, Plumbing, Heating Equipment"",
    ""hierarchy"": ""Wholesale > Wholesale Hardware, Plumbing, Heating Equipment"",
    ""description"": ""This industry includes entities that distribute wholesale hardware; plumbing and heating equipment and supplies (hydronics); warm air heating and air-conditioning equipment and supplies; and refrigeration equipment and supplies.""
  },
  {
    ""id"": 134,
    ""label"": ""Wholesale Import and Export"",
    ""hierarchy"": ""Wholesale > Wholesale Import and Export"",
    ""description"": ""This industry includes entities that facilitate trade of goods and commodities between domestic and foreign companies. Entities may buy/sell goods on their own account (import/export merchants) or on a commission basis (import/export agents and brokers). Subject to trade agreements between jurisdictions, they may handle tariffs and customs declarations and procedures.""
  },
  {
    ""id"": 1208,
    ""label"": ""Wholesale Luxury Goods and Jewelry"",
    ""hierarchy"": ""Wholesale > Wholesale Luxury Goods and Jewelry"",
    ""description"": ""This industry includes entities that distribute wholesale jewelry, precious and semiprecious stones, precious metals and metal flatware, costume jewelry, watches, clocks, silverware, and/or jewelers' findings.""
  },
  {
    ""id"": 1187,
    ""label"": ""Wholesale Machinery"",
    ""hierarchy"": ""Wholesale > Wholesale Machinery"",
    ""description"": ""This industry includes entities that distribute wholesale construction, mining, farm, garden, industrial, service establishment, and transportation machinery, equipment, and supplies.""
  },
  {
    ""id"": 1166,
    ""label"": ""Wholesale Metals and Minerals"",
    ""hierarchy"": ""Wholesale > Wholesale Metals and Minerals"",
    ""description"": ""This industry includes entities that engage in the merchant wholesale distribution of products of the primary metals industries (including metal service centers) and coal, coke, metal ores, and/or nonmetallic minerals (except precious and semiprecious stones and minerals used in construction, such as sand and gravel).""
  },
  {
    ""id"": 1128,
    ""label"": ""Wholesale Motor Vehicles and Parts"",
    ""hierarchy"": ""Wholesale > Wholesale Motor Vehicles and Parts"",
    ""description"": ""This industry includes entities that distribute wholesale automobiles and other motor vehicles, motor vehicle supplies, tires, and new or used parts.""
  },
  {
    ""id"": 1212,
    ""label"": ""Wholesale Paper Products"",
    ""hierarchy"": ""Wholesale > Wholesale Paper Products"",
    ""description"": ""This industry includes entities that distribute wholesale bulk printing and writing paper; stationery and office supplies; and industrial and personal service paper.""
  },
  {
    ""id"": 1262,
    ""label"": ""Wholesale Petroleum and Petroleum Products"",
    ""hierarchy"": ""Wholesale > Wholesale Petroleum and Petroleum Products"",
    ""description"": ""This industry includes entities that distribute wholesale petroleum and petroleum products, including liquefied petroleum gas.""
  },
  {
    ""id"": 1153,
    ""label"": ""Wholesale Photography Equipment and Supplies"",
    ""hierarchy"": ""Wholesale > Wholesale Photography Equipment and Supplies"",
    ""description"": ""This industry includes entities that distribute wholesale photographic equipment and supplies (except office equipment).""
  },
  {
    ""id"": 1250,
    ""label"": ""Wholesale Raw Farm Products"",
    ""hierarchy"": ""Wholesale > Wholesale Raw Farm Products"",
    ""description"": ""This industry includes entities that distribute wholesale agricultural products (except raw milk, live poultry, and fresh fruits and vegetables, which are in separate industries), such as grains, field beans, livestock, and other farm product raw materials (excluding seeds, which is in a separate industry).""
  },
  {
    ""id"": 1206,
    ""label"": ""Wholesale Recyclable Materials"",
    ""hierarchy"": ""Wholesale > Wholesale Recyclable Materials"",
    ""description"": ""This industry includes entities that distribute wholesale automotive scrap, industrial scrap, and other recyclable materials. Included in this industry are auto wreckers that dismantle motor vehicles for the purpose of wholesaling scrap.""
  }
]"; // Make sure this closing brace and semicolon are present
    }
}
