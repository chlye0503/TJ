// Fill out your copyright notice in the Description page of Project Settings.


#include "PlayerAnimInstance.h"

void UPlayerAnimInstance::UpdateSpeed()
{

    // Pawn을 가져오기
    APawn* PawnRef = TryGetPawnOwner();



    //없으면 안할거야
    if (!IsValid(PawnRef))
    {
        return;
    }

    FVector Velocity = PawnRef -> GetVelocity();

    CurrentSpeed = static_cast<float>(Velocity.Length());



}

void UPlayerAnimInstance::HandleUpdatedTarget(AActor* NewTargetActorRef)
{
    bIsInCombat = IsValid(NewTargetActorRef);
}

void UPlayerAnimInstance::UpdateDirection()
{
    APawn* PawnRef{ TryGetPawnOwner() };

    if(!IsValid(PawnRef))
    { 
        return; 
    }

    if(!bIsInCombat) 
    {
        return;
    }

     CurrentDirection = CalculateDirection(
        PawnRef->GetVelocity(), 
        PawnRef->GetActorRotation()
     );
}