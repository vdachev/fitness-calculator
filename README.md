# Fitness Calculator

### Measuring Energy

Energy can be measured in multiple units depending on the case:

- In [SI](https://en.wikipedia.org/wiki/International_System_of_Units), energy is measured primarily in **joule (J)**.
- Biological energy is usually measured in [calories](https://en.wikipedia.org/wiki/Calorie):
  - A **large calorie (Cal, ㎉)**, or food calorie is widely used in nutrition, and equals 4184 J.
  - A **small calorie (cal)**, or gram calorie is widely used in physics, and equals 4.184 J.

### Physiology Glossary

#### Body Mass Index (BMI)

The [Body mass index (BMI)]((https://en.wikipedia.org/wiki/Body_mass_index)) is a way of estimating a person's overall health.

BMI is measured in kg/m².

BMI can be used to determine a person category using the following table:

  | Category                              | From | To   |
  | ------------------------------------- | ---- | ---- |
  | Very severely underweight             |      | 15   |
  | Severely underweight                  | 15   | 16   |
  | Underweight                           | 16   | 18.5 |
  | Normal (healthy weight)               | 18.5 | 25   |
  | Overweight                            | 25   | 30   |
  | Obese Class I (moderately obese)      | 30   | 35   |
  | Obese Class II (Severely obese)       | 35   | 40   |
  | Obese Class III (Very severely obese) | 40   |      |

[BMI Prime](https://en.wikipedia.org/wiki/Body_mass_index#BMI_prime) can be used to show a person's BMI relative the the optimal BMI value of 25.

A new BMI formula has been [proposed](https://en.wikipedia.org/wiki/Body_mass_index#Proposed_New_BMI) but not yet widely accepted.

### Basal Metabolic Rate (BMR)

The [Basal metabolic rate (BMR)](https://en.wikipedia.org/wiki/Basal_metabolic_rate) the rate at which a person spends energy while being at rest.

BMR is measured in J/(h.kg).

BMR can be estimated by using the [Harris-Benedict Equation](https://en.wikipedia.org/wiki/Harris%E2%80%93Benedict_equation).

### Physical Activity Level (PAL)

The [Physical activity level (PAL)](https://en.wikipedia.org/wiki/Physical_activity_level) is a measure for a person's daily physical activity.

PAL is unitless.

PAL can be estimated using the following table:

  | Lifestyle                   | PAL          | Example
  | --------------------------- | ------------ | -------
  | Extremely inactive          | 1.40 or less | Cerebral palsy patient
  | Sedentary                   | 1.40 to 1.69 | Office worker getting little or no exercise
  | Moderately active           | 1.70 to 1.99 | Construction worker or person running one hour daily
  | Vigorously active           | 2.00 to 2.40 | Agricultural worker (non-mechanized) or person swimming two hours daily
  | Extremely active            | 2.40 or more | Competitive cyclist

### Total Energy Expenditure (TEE)

The [Total energy expenditure (TEE)](https://en.wikipedia.org/wiki/Energy_homeostasis#Expenditure) is the energy a person spends due to their metabolism, the thermic effect of food, plus their activity.

TEE is measured in J/(h.kg).

TEE can also be estimated by using the [Harris-Benedict Equation](https://en.wikipedia.org/wiki/Harris%E2%80%93Benedict_equation).

### Caloric Deficit

The [Caloric deficit](https://en.wikipedia.org/wiki/Caloric_deficit) is (rougly) the difference between the energy intake and the energy expended.

Caloric deficit is measured as energy.

The first law ot thermodynamics (and conservation of energy principle) say that:

  > Energy intake = Energy expended + Energy stored

  or

  > Energy stored = Energy expended - Energy intake

  where:

  - **Energy intake (EI)** is the the amount of energy a person consumes with food and/or fluids.
  - **Energy expended (EE)** is the amount of energy a person spends through their activity and/or the heat they generate
  - **Energy stored (ES)** is the amount of energy a person stores in body fat, triglycerides, or glycogen storage.
    - **Energy stored > 0** indicates **calorie surplus**
    - **Energy stored < 0** indicates **calorie deficit**

So, in order to lose weight, one can aim at calorie deficit by either:

- decreasing their energy intake (eating less); or
- increasing their physical activity (burning extra calories)

Depending on their goal, one can estimate their calorie consumption as follows:

| Weight Goal                   | Calorie Goal |
| ----------------------------- | ------------ |
| Maintain weight               | TEE          |
| Weight loss (slow but steady) | 85% of TEE   |
| Weight loss (average)         | 80% of TEE   |
| Weight loss (moderate)        | 75% of TEE   |
| Weight loss (aggressive)      | 70% of TEE   |

Notes:

- To reduce 1 kg of weight, about 7000 ㎉ deficit is required.
- In order to avoid malnutrition and/or starvation, one should not consume less than 1200 ㎉ for women, and 1800 ㎉ for men.

### Healthy Diet

There are many recommendations for a [healthy diet](https://en.wikipedia.org/wiki/Healthy_diet).

When it comes to [macronutrients](https://en.wikipedia.org/wiki/Nutrient#Macronutrients) (macros), one can calculate their recommended consumption from their calorie consumption (in ㎉):

| Fitness Goal    | Carbs  | Protein | Fat    |
| --------------- | ------ | ------- | ------ |
| Weight loss     | 10-30% | 40-50%  | 30-40% |
| Maintain weight | 30-50% | 25-35%  | 25-35% |
| Bodybuilding    | 40-60% | 25-35%  | 15-25% |
| Keto diet       | 5-10%  | 15-30%  | 60-75% |

Each gram of macronutrient provides energy as follows:

- Carbohydrates (Carbs) - 4 ㎉/g
- Protein - 4 ㎉/g
- Fat - 9 ㎉/g

### Calculation

Parameters that can be used for estimating various values are:

| Parameter    | Unit(s)        | Min | Max    |
| ------------ | -------------- | --- | ------ |
| Sex          | male or female | -   | -      |
| Age          | years          | 0   | 123    |
| Weight       | kg or lb       | 0   | 635 kg |
| Height       | cm or in       | 0   | 272 cm |
| Lifestyle    | see above      | -   | -      |
| Weight Goal  | see above      | -   | -      |
| Fitness Goal | see above      | -   | -      |

Notes:

- Age (for the purpose of this document) is considered the number of days from the birthday of a person divided by 365.25 days/year.
- "lb" stands for [pounds](https://en.wikipedia.org/wiki/Pound_(mass)), equals 0.45359237 kg
- "in" stands for [inches](https://en.wikipedia.org/wiki/Inch), equals 2.54 cm

Based on these parameters an application can calculate:

1. [PAL](#physical-activity-level-pal) using:
   - Lifestyle
2. [BMI](#body-mass-index-bmi) using:
   - Wight
   - Height
3. [BMR](#basal-metabolic-rate-bmr) using:
   - Sex
   - Age
   - Weight
   - Height
4. [TEE](#total-energy-expenditure-tee) using:
   - PAL
   - BMR
5. [Calorie Goal](#calorie-deficit) using:
   - TEE
   - Weight Goal
6. [Diet](#healthy-diet) using:
   - Calorie Goal

### Further Read

- [What Is the Macro Diet—And Can It Help Me Lose Weight?](https://www.cookinglight.com/eating-smart/macro-diet-counting-macros-weight-loss-better-nutrition)
- [Everything You Need to Know About Counting Macros for Weight Loss
](https://www.menshealth.com/weight-loss/a19540439/how-to-count-macronutrients-iifym-eating-plan/)
- [How to Calculate Your Ideal Macronutrients Intake](https://shapescale.com/blog/health/nutrition/calculate-macronutrient-ratio/)
